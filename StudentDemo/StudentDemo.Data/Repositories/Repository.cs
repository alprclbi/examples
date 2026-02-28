using Microsoft.EntityFrameworkCore;
using StudentDemo.Core.Interfaces;
using StudentDemo.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Data.Repositories

// <summary>
// Repository - Generic Repository  Implementation
//
// SOLID Prensipleri:
// - Single Responsibility: Sadece temel CRUD işlemlerini yönetir.
// - Open/Closed: Yeni entity türleri eklemek için mevcut kodu değiştirmeye gerek yoktur.
// - Dependency Inversion: IRepository arayüzüne bağımlıdır, somut sıniflara değil. interfacei implement eder.
// NOT: Bu sinif abstract olarak tanimlanmis , dogrudan kullanilamaz
// BookRepository ce AuthorRepository bu sinifi inherit eder
// </summary>
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        protected Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        //<summary>
        //Tum kayitlari getirir
        //</summary>
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        // <summary>
        // Id'ye göre kayit getirir
        // </summary>
        public virtual async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        // <summary>
        // Kosula gore filtreleme yapar(Lambda Expression kullanarak)
        // Orne: FindAsync(b => b.Price > 100) gibi
        // </summary>
        public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        // <summary>
        // Yeni kayit ekler
        // NOT: Savechanges cagrilana kadar veritabanina kaydedilmez
        // </summary>
        public virtual async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        // <summary>
        // Kayit gunceller
        // NOT: Savechanges cagrilana kadar veritabanina kaydedilmez
        // </summary>
        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        // <summary>
        // Kayit siler
        // NOT: Savechanges cagrilana kadar veritabanina kaydedilmez
        // </summary>
        public virtual void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);

        }
        // <summary>
        //ID'ye gore kayit var mi kontrol eder
        // </summary>
        public virtual async Task<bool> ExistsAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            return entity != null;
        }
    }
}
