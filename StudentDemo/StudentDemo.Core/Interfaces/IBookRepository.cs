using StudentDemo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Core.Interfaces

/// <summary>
/// IBookREpository - Kitap Repository Interface
/// 
/// SOLID Prensipleri:
///  - Single Responsibilty: Sadece kitap veri erişim işlemleri
///  - Interface Segregation: IRepository'den türetilmiş + kitaba özel metotlar
///  - Liskov Substitution: IRepository<Book> yerine kullanılabilir 
/// </summary>
{
    public interface IBookRepository : IRepository<Book>
    {
        // Kitaba özel metotlar
        Task<IEnumerable<Book>> GetBooksByAuthorIdAsync(int authorId);
        Task<Book?> getBookWithAuthorAsync(int id);
        Task<IEnumerable<Book>> getAllWithAuthorsAsync();
        Task<Book?> GetByIsbnAsync(string isbn);
    }
}
