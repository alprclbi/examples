using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Core.Interfaces

/// <summary>
/// IunitOfWork - Unıt Of Work Pattern Interface
/// 
/// Amaç: Birden fazla repository işlemini tek bir transaction'da yönetmek
/// 
/// Örnek Senaryo:
///  - Bir yazar eklenirken aynı anda kitaplerı da eklenmeli
///  - İşlemlerden biri başarısız olursa hepsi geri alınmalı (rollback)
///  
/// SOLID: Single Responsibility - Sadece transaction yönetimi
/// </summary>
{
    public interface IUnitOfWork : IDisposable
    {
        // Repository'lere erişim
        IBookRepository Books { get; }

        IAuthorRepository Authors { get; }

        // Tüm değişiklikleri kaydet
        Task<int> SaveChangesAsync();

        // Transaction başlat
        Task BeginTransactionAsync();

        // Transaction onayla
        Task CommitTransactionAsync();

        // Transaction geri al
        Task RollbackTransactionAsync();
    }
}
