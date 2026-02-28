using Microsoft.EntityFrameworkCore;
using StudentDemo.Core.Entities;
using StudentDemo.Core.Interfaces;
using StudentDemo.Data.Context;

namespace StudentDemo.Data.Repositories
/// <summary>
/// Author Repository - Yazar Repository Implementasyonu
/// 
//SOLID Prensipleri:
//- Single Responsibility: Yazarlarla ilgili işlemleri yönetir.
//- Open/Closed: Yeni özellikler eklemek için mevcut kodu değiştirmeye gerek yoktur.
//- Dependency Inversion: IRepository<Author> arayüzüne bağımlıdır, somut sınıflara değil. Repository sınıfını implement eder.
/// </summary>
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(AppDbContext context) : base(context)
        {
        }
        // <summary>
        // Yazari kitaplariyla birlikte getirir (Eager loading)
        // </summary>
        public async Task<Author?> GetAuthorWithBooksAsync(int id)
        {
            return await _dbSet.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == id);
        }

        // <summary>
        //tum yazarlari kitaplariyla birlikte getirir (Eager loading)
        // </summary>
        public async Task<IEnumerable<Author>> GetAllWithBooksAsync()
        {
            return await _dbSet.Include(a => a.Books).ToListAsync();
        }

        // <summary>
        // Ulkeye gore yazarlari getirir
        // </summary>
        public async Task<IEnumerable<Author>> GetAuthorsByCountryAsync(string country)
        {
            return await _dbSet.Where(a => a.Country == country).Include(a=>a.Books).ToListAsync();
        }

    }
}
