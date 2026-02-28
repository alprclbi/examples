using Microsoft.EntityFrameworkCore;
using StudentDemo.Core.Interfaces;
using StudentDemo.Core.Services;
using StudentDemo.Data;
using StudentDemo.Data.Context;
using StudentDemo.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// =============================================================================
// DEPENDENCY INJECTION (DI) KAYITLARI
// =============================================================================
// DI Container'a servisleri kaydediyoruz
// Bu sayede "new" keyword'ü kullanmadan baðýmlýlýklar otomatik enjekte edilir
//
// SOLID - Dependency Inversion:
// Somut sýnýflar yerine interface'leri kaydediyoruz
// =============================================================================

// 1. DbContext kaydý
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Repository kayýtlarý
// AddScoped: Her HTTP request için yeni instance oluþturulur
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();

// 3. UnitOfWork kaydý
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// 4. Service kayýtlarý
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();

// =============================================================================
// YAÞAM SÜRESÝ (LIFETIME) SEÇENEKLERÝ
// =============================================================================
// AddSingleton : Uygulama boyunca tek instance (örn: configuration, cache)
// AddScoped    : HTTP request baþýna bir instance (örn: DbContext, services)
// AddTransient : Her çaðrýda yeni instance (örn: lightweight, stateless services)
// =============================================================================

// Controller'larý ekle
builder.Services.AddControllers();

// Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new()
    {
        Title = "StudentDemo API",
        Version = "v1",
        Description = "DB First & SOLID Prensipleri Demo API"
    });
});

var app = builder.Build();

// Swagger UI (Development ortamýnda)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "StudentDemo API v1");
        c.RoutePrefix = "swagger"; // Ana sayfada Swagger açýlsýn
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
