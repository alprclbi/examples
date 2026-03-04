using Microsoft.EntityFrameworkCore;
using StudentDemo.Core.Interfaces;
using StudentDemo.Core.Services;
using StudentDemo.Data;
using StudentDemo.Data.Context;
using StudentDemo.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

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

    int retryCount = 0;
    bool success = false;

    while (!success && retryCount < 10)
    {
        try
        {
            var connString = context.Database.GetConnectionString();
            logger.LogInformation("Veritabanı migrasyonu deneniyor (Deneme {RetryCount})... Conn: {Conn}", retryCount + 1, connString?.Split(';')[0]);
            context.Database.Migrate();
            success = true;
            logger.LogInformation("Veritabanı migrasyonu başarıyla tamamlandı.");
        }
        catch (Exception ex)
        {
            retryCount++;
            logger.LogWarning("Migrasyon başarısız (Deneme {RetryCount}): {Message}", retryCount, ex.Message);
            if (retryCount >= 10)
            {
                logger.LogCritical(ex, "Maksimum deneme sayısına ulaşıldı. Uygulama kapatılıyor.");
                throw;
            }
            Thread.Sleep(5000); // 5 saniye bekle ve tekrar dene
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

app.UseAuthorization();
app.MapControllers();

app.Run();
