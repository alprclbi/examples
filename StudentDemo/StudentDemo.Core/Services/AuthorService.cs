using StudentDemo.Core.DTOs;
using StudentDemo.Core.Entities;
using StudentDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Core.Services;

/// <summary>
/// AuthoorService - Yaza İş Mantığı Katmanı
/// 
/// - Single Responsibility: Sadece yazar iş mantığını içerir.
/// - Dependency Inversion: IUnırOfWork interface'ine bağımlı
/// - Interface Segregation: Alt sınıflar üst sınfılara ait interfaceleri kullanır.
/// </summary>

public class AuthorService
{
    private readonly IUnitOfWork _unitOfWork;

    public AuthorService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// Tüm yazarları getirir.
    /// </summary>

    public async Task<IEnumerable<AuthorDto>> GettAllAuthorsAsync()
    {
        var authors = await _unitOfWork.Authors.GetAllWithBooksAsync();
        return authors.Select(MapToDto);
    }

    /// <summary>
    /// ID'ye göre yazar getirir.
    /// </summary>
    /// 
    public async Task<AuthorDto?> GetAuthorByIdAsync(int id)
    {
        var author = await _unitOfWork.Authors.GetAuthorWithBooksAsync(id);
        return author == null ? null : MapToDto(author);
    }

    /// <summary>
    /// Yazarı kitaplarıyla birlikte getirir
    /// </summary>

    public async Task<AuthorWithBooksDto?> GetAuthorWithBooksAsync(int id)
    {
        var author = await _unitOfWork.Authors.GetAuthorWithBooksAsync(id);
        return author == null ? null : MapToDetailDto(author);
    }

    /// <summary>
    /// Ülkeye göre yazarları getirir
    /// </summary>
    public async Task<IEnumerable<AuthorDto>> GetAuthorsByCountryAsync(string country)
    {
        var authors = await _unitOfWork.Authors.GetAuthorsByCountryAsync(country);
        return authors.Select(MapToDto);
    }

    /// <summary>
    /// Yeni yazar oluşturur
    /// </summary>
    public async Task<AuthorDto> CreateAuthorAsync(CreateAuthorDto dto)
    {
        var author = new Author
        {
            Name = dto.Name,
            Country = dto.Country,
            CreatedAt = DateTime.UtcNow
        };
        await _unitOfWork.Authors.AddAsync(author);
        await _unitOfWork.SaveChangesAsync();

        return MapToDto(author);
    }

    /// <summary>
    /// Yazar günceller
    /// </summary>
    public async Task<AuthorDto?> UpdateAuthorAsync(int id, UpdateAuthorDto dto)
    {
        var author = await _unitOfWork.Authors.GetByIdAsync(id);
        if (author == null) return null;

        author.Name = dto.Name;
        author.Country = dto.Country;

        _unitOfWork.Authors.Update(author);
        await _unitOfWork.SaveChangesAsync();
        return MapToDto(author);
    }

    /// <summary>
    /// Yazar siler
    /// </summary>
    public async Task<bool> DeleteAuthorAsync(int id)
    {
        var author = await _unitOfWork.Authors.GetByIdAsync(id);
        if (author == null) return false;

        _unitOfWork.Authors.Delete(author);
        await _unitOfWork.SaveChangesAsync();
        return true;
    }

    /// <summary>
    /// Entity'den DTO'ya dönüşüm
    /// </summary>
    private static AuthorDto MapToDto(Author author)
    {
        return new AuthorDto
        {
            Id = author.Id,
            Name = author.Name,
            Country = author.Country,
            CreatedAt = author.CreatedAt,
            BookCount = author.Books?.Count ?? 0
        };
    }

    /// <summary>
    /// Entity'den detaylı DTO'ya dönüşüm (Kitaplarla birlikte)
    /// </summary>
    private static AuthorWithBooksDto MapToDetailDto(Author author)
    {
        return new AuthorWithBooksDto
        {
            Id = author.Id,
            Name = author.Name,
            Country = author.Country,
            CreatedAt = author.CreatedAt,
            Books = author.Books?.Select(b => new BookDto
            {
                Id = b.Id,
                Title = b.Title,
                // ISBN = b.ISBN,
                Price = b.Price,
                AuthorId = b.AuthorId,
                AuthorName = author.Name,
                CreatedAt = b.CreatedAt
            }).ToList() ?? new List<BookDto>()
        };
    }
}
