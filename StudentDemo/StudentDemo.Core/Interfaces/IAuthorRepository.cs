using StudentDemo.Core.Entities;

namespace StudentDemo.Core.Interfaces

/// <summary>
/// IBookREpository - Yazar Repository Interface
/// 
/// SOLID Prensipleri:
///  - Single Responsibilty: Sadece kitap veri erişim işlemleri
///  - Interface Segregation: IRepository'den türetilmiş + kitaba özel metotlar
///  - Liskov Substitution: IRepository<Author> yerine kullanılabilir 
/// </summary>
{
    public interface IAuthorRepository : IRepository<Author>
    {
        // Yazar özel metotlar
        Task<Author?> GetAuthorWithBooksAsync(int id);

        Task<IEnumerable<Author>> GetAllWithBooksAsync();

        Task<IEnumerable<Author>> GetAuthorsByCountryAsync(string country);

    }
}
