using System.Data;
using Microsoft.EntityFrameworkCore;
using StudentDemo.Core.Interfaces;
using StudentDemo.Core.Services;
using StudentDemo.Data;
using StudentDemo.Data.Context;
using StudentDemo.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);
// CORS politikasını tanımla
builder.Services.AddCors(options =>
{
    options.AddPolicy("FronendPolicy", policy =>
    {
        policy.AllowAnyOrigin()   // Şimdilik test için her yere izin verelim
              .AllowAnyMethod()   // GET, POST, PUT, DELETE hepsine izin ver
              .AllowAnyHeader();  // Tüm header'lara izin ver
    });
});

// DbContext kaydı
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var dockerConn = Environment.GetEnvironmentVariable("SQL_CONN");
if (!string.IsNullOrEmpty(dockerConn)) 
{
    connectionString = dockerConn;
}
Console.WriteLine($"Connection string: {connectionString?.Split(';')[0]}");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString,
    sqlServerOptionsAction: sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 10,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null);
    }));

// Repository kayıtları
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();

// UnitOfWork kaydı
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Service kayıtları
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new()
    {
        Title = "StudentDemo API",
        Version = "v1",
        Description = "Dockerized API with Robust Auto-Migration"
    });
});

var app = builder.Build();

// =============================================================================
// OTOMATİK MİGRASYON BLOĞU (RETRY DESTEKLİ)
// =============================================================================
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var logger = services.GetRequiredService<ILogger<Program>>();
    var context = services.GetRequiredService<AppDbContext>();

    var retryCount = 0;
    var success = false;

    logger.LogInformation("SQL Server bağlantısı bekleniyor...");
    await Task.Delay(5000);

    while (!success && retryCount < 12)
    {
        try
        {
            var connString = context.Database.GetConnectionString();
            logger.LogInformation(
                "Veritabanı migrasyonu deneniyor (Deneme {RetryCount})... Server: {Server}",
                retryCount + 1,
                connString?.Split(';').FirstOrDefault(x => x.StartsWith("Server")));

            await context.Database.OpenConnectionAsync();
            await context.Database.CloseConnectionAsync();

            var appliedMigrations = (await context.Database.GetAppliedMigrationsAsync()).ToList();
            var pendingMigrations = (await context.Database.GetPendingMigrationsAsync()).ToList();

            if (pendingMigrations.Count == 0)
            {
                logger.LogInformation("Bekleyen migration bulunmuyor.");
                success = true;
                continue;
            }

            await using var connection = context.Database.GetDbConnection();
            if (connection.State != ConnectionState.Open)
            {
                await connection.OpenAsync();
            }

            await using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT COUNT(*)
                FROM INFORMATION_SCHEMA.TABLES
                WHERE TABLE_NAME IN ('Authors', 'Books')
                """;

            var existingTables = Convert.ToInt32(await command.ExecuteScalarAsync());

            if (appliedMigrations.Count == 0 && existingTables > 0)
            {
                throw new InvalidOperationException(
                    "Veritabanında tablolar mevcut, ancak __EFMigrationsHistory boş. " +
                    "Migration geçmişi ile veritabanı senkron değil.");
            }

            await context.Database.MigrateAsync();
            success = true;
            logger.LogInformation("Veritabanı migrasyonu başarıyla tamamlandı.");
        }
        catch (InvalidOperationException ex) when (
            ex.Message.Contains("__EFMigrationsHistory") ||
            ex.Message.Contains("zaten mevcut") ||
            ex.Message.Contains("already an object named"))
        {
            logger.LogCritical(ex, "Migration geçmişi ile veritabanı uyumsuz. Uygulama durduruluyor.");
            throw;
        }
        catch (Exception ex)
        {
            retryCount++;
            logger.LogWarning(
                "Migrasyon başarısız (Deneme {RetryCount}). Hata: {Message}",
                retryCount,
                ex.Message);

            if (retryCount >= 12)
            {
                logger.LogCritical(ex, "Maksimum deneme sayısına ulaşıldı. Uygulama kapatılıyor.");
                throw;
            }

            var delay = retryCount * 5000;
            logger.LogInformation("{Delay} ms sonra tekrar denenecek...", delay);
            await Task.Delay(delay);
        }
    }
}

// Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "StudentDemo API v1");
        c.RoutePrefix = "swagger";
    });
}

app.UseCors("FronendPolicy");
app.UseAuthorization();
app.MapControllers();

app.Run();
