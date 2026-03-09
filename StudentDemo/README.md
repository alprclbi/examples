# 📚 .NET Core Web API - DB First & SOLID Prensipleri Demo

Bu proje,  **DB First yaklaşımı** ve **SOLID prensiplerini** öğretmek için hazırlanmış basit bir Kitap Yönetim API'sidir.

---

## 🎯 Proje Amacı

Basit bir **Kitap & Yazar** yönetim sistemi üzerinden:
- DB First yaklaşımını
- SOLID prensiplerini
- Repository Pattern'i
- Dependency Injection'ı

uygulamalı olarak öğretmek.

---

## 📁 Proje Yapısı

```
StudentDemo/
├── StudentDemo.API/              # Web API Katmanı (Presentation)
│   ├── Controllers/
│   │   ├── BooksController.cs
│   │   └── AuthorsController.cs
│   ├── Program.cs
│   └── appsettings.json
│
├── StudentDemo.Core/             # İş Mantığı Katmanı (Business)
│   ├── Entities/                 # Entity sınıfları (DB First ile oluşur)
│   │   ├── Book.cs
│   │   └── Author.cs
│   ├── Interfaces/               # Repository & UnitOfWork Interface'leri
│   │   ├── IRepository.cs        # Generic Repository Interface
│   │   ├── IBookRepository.cs
│   │   ├── IAuthorRepository.cs
│   │   └── IUnitOfWork.cs
│   ├── Services/
│   │   ├── IBookService.cs
│   │   ├── BookService.cs
│   │   ├── IAuthorService.cs
│   │   └── AuthorService.cs
│   └── DTOs/
│       ├── BookDto.cs
│       └── AuthorDto.cs
│
├── StudentDemo.Data/             # Veri Erişim Katmanı (Data Access)
│   ├── Context/
│   │   └── AppDbContext.cs       # DB First ile oluşturulan context
│   ├── Repositories/             # Repository Implementation'ları
│   │   ├── Repository.cs         # Generic Repository
│   │   ├── BookRepository.cs
│   │   └── AuthorRepository.cs
│   └── UnitOfWork.cs
│
├── Database/
│   └── CreateDatabase.sql        # Veritabanı oluşturma script'i
│
└── README.md
```


### 🔗 Katman Bağımlılıkları (Doğru Yön!)

```
StudentDemo.API
    ├── → StudentDemo.Core
    └── → StudentDemo.Data

StudentDemo.Data
    └── → StudentDemo.Core    ← Data, Core'a bağımlı (Entity ve Interface için)

StudentDemo.Core
    └── (Bağımsız - Hiçbir katmana bağımlı değil!)
```

**ÖNEMLİ:** Core katmanı hiçbir katmana bağımlı değil! Bu sayede:
- Entity'ler ve Interface'ler Core'da tanımlanır
- Data katmanı bu interface'leri implemente eder
- Dependency Inversion prensibi sağlanır

---

## 🔤 SOLID Prensipleri Açıklaması

### S - Single Responsibility (Tek Sorumluluk)
> Her sınıfın tek bir görevi olmalı.

```
✅ BookService      → Sadece kitap iş mantığı
✅ BookRepository   → Sadece kitap veritabanı işlemleri
✅ BooksController  → Sadece HTTP isteklerini yönetme
```

### O - Open/Closed (Açık/Kapalı)
> Sınıflar genişletmeye açık, değişikliğe kapalı olmalı.

```csharp
// Generic Repository sayesinde yeni entity'ler için kod değiştirmeden genişletebiliriz
public class Repository<T> : IRepository<T> where T : class
{
    // Tüm entity'ler için ortak CRUD işlemleri
}

// Yeni bir entity eklendiğinde Repository<T> değişmiyor
public class BookRepository : Repository<Book>, IBookRepository { }
public class AuthorRepository : Repository<Author>, IAuthorRepository { }
```

### L - Liskov Substitution (Liskov Yerine Geçme)
> Alt sınıflar, üst sınıfların yerine kullanılabilmeli.

```csharp
// IBookRepository, IRepository<Book>'tan türetilmiş
// BookRepository her ikisinin de yerine kullanılabilir
IRepository<Book> repo = new BookRepository();  // ✅ Çalışır
IBookRepository bookRepo = new BookRepository(); // ✅ Çalışır
```

### I - Interface Segregation (Arayüz Ayrımı)
> Büyük interface'ler yerine küçük, özel interface'ler kullan.

```csharp
// ❌ YANLIŞ - Tek büyük interface
public interface IAllOperations
{
    void AddBook();
    void AddAuthor();
    void SendEmail();
    void GenerateReport();
}

// ✅ DOĞRU - Ayrı interface'ler
public interface IBookRepository { }
public interface IAuthorRepository { }
public interface IEmailService { }
```

### D - Dependency Inversion (Bağımlılık Tersine Çevirme)
> Somut sınıflara değil, soyutlamalara (interface) bağımlı ol.

```csharp
// ❌ YANLIŞ - Somut sınıfa bağımlı
public class BookService
{
    private BookRepository _repo = new BookRepository(); // Sıkı bağımlılık
}

// ✅ DOĞRU - Interface'e bağımlı (Dependency Inversion)
public class BookService : IBookService
{
    private readonly IBookRepository _repo;
    
    public BookService(IBookRepository repo) // Constructor Inversion
    {
        _repo = repo;
    }
}
```

---

## 🗄️ DB First Yaklaşımı

### Adım 1: Veritabanını Oluştur (SQL Server)

```sql
-- Veritabanını oluştur
CREATE DATABASE BookStoreDB;
GO

USE BookStoreDB;
GO

-- Authors tablosu
CREATE TABLE Authors (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Country NVARCHAR(50),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Books tablosu
CREATE TABLE Books (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(200) NOT NULL,
    ISBN NVARCHAR(20),
    Price DECIMAL(10,2),
    AuthorId INT FOREIGN KEY REFERENCES Authors(Id),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Test verileri
INSERT INTO Authors (Name, Country) VALUES 
('Orhan Pamuk', 'Türkiye'),
('Yaşar Kemal', 'Türkiye'),
('Sabahattin Ali', 'Türkiye');

INSERT INTO Books (Title, ISBN, Price, AuthorId) VALUES 
('Kar', '978-1234567890', 45.00, 1),
('Masumiyet Müzesi', '978-1234567891', 55.00, 1),
('İnce Memed', '978-1234567892', 40.00, 2),
('Kürk Mantolu Madonna', '978-1234567893', 35.00, 3);
```

### Adım 2: Scaffold Komutu (Entity'leri Otomatik Oluştur)

```bash
# Package Manager Console veya Terminal'de:
cd StudentDemo.Data

dotnet ef dbcontext scaffold "Server=.\SQLEXPRESS;Database=BookStoreDB;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -o Entities -c AppDbContext --context-dir Context -f
```

Bu komut:
- `-o Entities` → Entity sınıflarını Entities klasörüne koyar
- `-c AppDbContext` → Context sınıfının adı
- `--context-dir Context` → Context'i Context klasörüne koyar
- `-f` → Varolan dosyaları override eder

---

## 🚀 Kurulum Adımları

### 1. Solution ve Projeler Oluştur

```bash
# Solution oluştur
dotnet new sln -n StudentDemo

# Projeleri oluştur
dotnet new webapi -n StudentDemo.API
dotnet new classlib -n StudentDemo.Core
dotnet new classlib -n StudentDemo.Data

# Solution'a ekle
dotnet sln add StudentDemo.API
dotnet sln add StudentDemo.Core
dotnet sln add StudentDemo.Data

# Referansları ekle
cd StudentDemo.API
dotnet add reference ../StudentDemo.Core
dotnet add reference ../StudentDemo.Data

cd ../StudentDemo.Core
dotnet add reference ../StudentDemo.Data

cd ../StudentDemo.Data
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

### 2. NuGet Paketleri

```xml
<!-- StudentDemo.Data.csproj -->
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.0" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.0" />

<!-- StudentDemo.API.csproj -->
<PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.0" />
```

---

## 📝  Özet

| Kavram | Açıklama | Dosya Örneği |
|--------|----------|--------------|
| DB First | Önce DB, sonra kod | Scaffold komutu |
| Entity | Veritabanı tablosu karşılığı | Book.cs, Author.cs |
| DTO | Veri transfer nesnesi | BookDto.cs |
| Repository | Veri erişim katmanı | BookRepository.cs |
| Service | İş mantığı katmanı | BookService.cs |
| Controller | HTTP endpoint'leri | BooksController.cs |
| DI | Bağımlılık enjeksiyonu | Program.cs |

---

## 🧪 Test Endpoint'leri

```
GET    /api/books          → Tüm kitapları getir
GET    /api/books/5        → ID'ye göre kitap getir
POST   /api/books          → Yeni kitap ekle
PUT    /api/books/5        → Kitap güncelle
DELETE /api/books/5        → Kitap sil

GET    /api/authors        → Tüm yazarları getir
GET    /api/authors/5      → ID'ye göre yazar getir
GET    /api/authors/5/books → Yazarın kitaplarını getir
```

---

## 💡 Önemli Notlar

1. **Katmanlı Mimari**: Her katmanın tek sorumluluğu var
2. **Interface Kullanımı**: Soyutlama ile gevşek bağlılık
3. **Dependency Injection**: Test edilebilirlik ve esneklik
4. **Generic Repository**: Kod tekrarını önler
5. **DTO Pattern**: Entity'leri doğrudan expose etme

---

## 📚 Daha Fazla Öğrenmek İçin

- [Microsoft Docs - EF Core](https://docs.microsoft.com/ef/core/)
- [SOLID Principles](https://www.digitalocean.com/community/conceptual-articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design)
- [Repository Pattern](https://docs.microsoft.com/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application)
