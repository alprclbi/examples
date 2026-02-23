using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace StudentDemo.Core.Interfaces

/// <summary>
/// IRepository - Generic Repository Pattern Interface
/// 
/// SOLID Prensipleri:
/// - Interface Segregation Principle: Sadece temel CRUD operasyonlarını için arı interfaceler
/// - Dependency Inversion Principle: Somut sınıf yerine interface'e bağımlılık
/// - Open/Closed Principle: Generic yapı sayesinde yeni entity'ler için genişletilebilir.
/// </summary>
/// <typeparam name="T">Entity tipi</typeparam>
{
    public interface IRepository<T> where T : class
    {
        // Tüm kayıtları getir
        Task<IEnumerable<T>> GetAllAsync();

        // Id'ye göre kayıt getir
        Task<T?> GetByIdAsync(int id);

        // Koşula göre filtreleme
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        // Yeni kayıt ekle
        Task<T> AddAsync(T entity);

        // Kayıt güncelle
        void Update(T entity);

        // Kayıt sil
        void Delete(T entity);

        // Kayıt var mı kontrol et
        Task<bool> ExistsAsync(int id);
    }
}
