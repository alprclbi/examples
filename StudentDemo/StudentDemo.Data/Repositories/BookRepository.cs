using Microsoft.EntityFrameworkCore;
using StudentDemo.Core.Entities;
using StudentDemo.Core.Interfaces;
using StudentDemo.Data.Context;

namespace StudentDemo.Data.Repositories;
/// <summary>
/// BookRepository - Kitap Repository Implementasyonu
/// 
//SOLID Prensipleri:
//- Single Responsibility: Kitaplarla ilgili işlemleri yönetir.
//- Open/Closed: Yeni özellikler eklemek için mevcut kodu değiştirmeye gerek yoktur.
//- Dependency Inversion: IRepository<Book> arayüzüne bağımlıdır, somut sınıflara değil. Repository sınıfını implement eder.
/// </summary>

public class BookRepository : Repository<Book>, IBookRepository
{
    public BookRepository(AppDbContext context) : base(context)
    { }

    // <summary>
    //Yazara gore kitaplari getirir
    // </summary>
    public async Task<IEnumerable<Book>> GetBooksByAuthorIdAsync(int authorId)
    {
        return await _dbSet.Where(b => b.AuthorId == authorId).Include(b => b.Author).ToListAsync();
    }

    // <summary>
    // Kitapi yazariyla birlikte getirir (Eager loading)
    // </summary>
    public async Task<Book?> GetBookWithAuthorAsync(int id)
    {
        return await _dbSet.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
    }

    // <summary>
    // Tum kitaplari yazarlariyla birlikte getirir (Eager loading)
    // </summary>
    public async Task<IEnumerable<Book>> GetAllWithAuthorsAsync()
    {
        return await _dbSet.Include(b => b.Author).ToListAsync();
    }

    // <summary>
    // ISBN'e göre kitap getirir
    // </summary>
    public async Task<Book?> GetByIsbnAsync(string isbn)
    {
        return await _dbSet.Include(b => b.Author).FirstOrDefaultAsync(b => b.Isbn == isbn);
    }

}
