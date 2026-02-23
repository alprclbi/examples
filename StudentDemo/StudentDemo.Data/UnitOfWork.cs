using Microsoft.EntityFrameworkCore.Storage;
using StudentDemo.Core.Interfaces;
using StudentDemo.Data.Context;
using StudentDemo.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Data
/// <summary>
/// UnitOfWork - Birim Çalışması Deseni - Unit Of Work Pattern Implementasyonu
/// 
/// Amac:
///  - Birden fazla repository'yi tek bir işlemde(transaction'da) yönetmek
///  - tek bir SaveChanges() çağrısıyla tüm değişiklikleri veritabanına kaydetmek
///  - Repository instance'larını yönetmek
///  
///  SOLID:
///  - Single Responsibility Principle: Sadece trasnaction yönetimi ve repository'lerin yönetimini sağlar
///  - Dependency Inversıon: IUnıtOfWrok ınterface'ini implemente eder.
///  </summary>
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IDbContextTransaction? _transaction;

        // Repository'ler - Lazy initialization ile oluşturulur.
        private IBookRepository? _bookRepository;
        private IAuthorRepository? _authorRepository;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Book Repository - İlk çağrıldığında oluşturulur. Sonraki çağrılarda aynı instance döner.
        /// </summary>

        public IBookRepository Books => _bookRepository ??= new BookRepository(_context);

        /// <summary>
        /// Author Repository - İlk çağrıldığında oluşturulur. Sonraki çağrılarda aynı instance döner.
        /// </summary>

        public IAuthorRepository Authors => _authorRepository ??= new AuthorRepository(_context);

        /// <summary>
        /// Tüm değişiklikleri veritabanına kaydeder.
        /// </summary> 

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Transaction başlatır.
        /// Birden fazla işlemi atomik olarak yapmak için kullanılır.
        /// </summary>
        /// 
        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        /// <summary>
        /// Transaction'ı commit eder. Yani yapılan değişiklikleri kalıcı hale getirir.
        /// </summary>
        
        public async Task CommitTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        /// <summary>
        /// Transaction'ı geri alır (rollback)
        /// Hata durumunda tüm değişiklikleri iptal etmek için kullanılır.
        /// </summary>
        
        public async Task RollbackTransactonAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }
        /// <summary>
        /// Kaynaklerı serbest bırakır.
        /// </summary>
        
        public void Dispose()
        {
            _transaction?.Dispose();
            _context.Dispose();
        }
    }
}
