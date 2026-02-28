using StudentDemo.Core.DTOs;
using StudentDemo.Core.Entities;
using StudentDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Core.Services

/// <summary>
/// BookService - Kitap İş Mantığı Katmanı
/// 
/// SOLID Prensipleri:
/// - Single Responsibility: Sadece kitap iş mantığı
/// - Dependency Inversion: IUnitOfWork interface'ine bağımlı (somut sınıfa değil)
/// 
/// Bu katman:
/// - Repository'den gelen Entity'leri DTO'ya dönüştürür
/// - İş kurallarını uygular (validation, hesaplamalar vb.)
/// - Controller ile Data katmanı arasında köprü görevi görür
/// </summary>
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;

        // Constructor Injection - SOLID: Dependency Inversion
        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Tüm kitapları getirir
        /// </summary>
        
        public async Task<IEnumerable<BookDto>> GetAllBooksAsync()
        {
            var books = await _unitOfWork.Books.GetAllWithAuthorsAsync();
            return books.Select(MapToDto);
        }

        /// <summary>
        /// ID'ye göre kitap getirir
        /// </summary>
        
        public async Task<BookDto?> GetBookByIdAsync(int id)
        {
            var book = await _unitOfWork.Books.GetBookWithAuthorAsync(id);
            return book == null ? null : MapToDto(book);
        }


        /// <summary>
        /// Yazara göre kitapları getirir
        /// </summary>
        
        public async Task<IEnumerable<BookDto>> GetBooksByAuthorIdAsync(int authorId)
        {
            var books = await _unitOfWork.Books.GetBooksByAuthorIdAsync(authorId);
            return books.Select(MapToDto);
        }

        /// <summary>
        /// ISBN'e göre kitap getirir
        /// </summary>
        /// 
        public async Task<BookDto?> GetBookByIsbnAsync(string isbn)
        {
            var book = await _unitOfWork.Books.GetByIsbnAsync(isbn);
            return book == null ? null : MapToDto(book);
        }

        /// <summary>
        /// Yeni kitap oluşturur
        /// </summary>
        
        public async Task<BookDto> CreateBookAsync(CreateBookDto dto)
        {
            var book = new Book
            {
                Title = dto.Title,
                // ISBN = dto.ISBN
                Price = dto.Price,
                AuthorId = dto.AuthorId,
                CreatedAt = DateTime.UtcNow
            };
            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.SaveChangesAsync();

            // Eklenen kitabı yazarıyla birlikte getir
            var createdBook = await _unitOfWork.Books.GetBookWithAuthorAsync(book.Id);
            return MapToDto(createdBook!);
        }

        /// <summary>
        /// Kitap günceller
        /// </summary>
        
        public async Task<BookDto?> UpdateBookAsync(int id, UpdateBookDto dto)
        {
            var book = await _unitOfWork.Books.GetByIdAsync(id);
            if (book == null) return null;

            // Entity güncelleme
            book.Title = dto.Title;
            // book.ISBN = dto.ISBN;
            book.Price = dto.Price;
            book.AuthorId = dto.AuthorId;

            _unitOfWork.Books.Update(book);
            await _unitOfWork.SaveChangesAsync();

            // Guncelleme sonrası kitabı yazarıyla birlikte getir
            var updatedBook = await _unitOfWork.Books.GetBookWithAuthorAsync(id);
            return MapToDto(updatedBook!);
        }

        /// <summary>
        /// Kitap siler
        /// </summary>
        
        public async Task<bool> DeleteBookAsync(int id)
        {
            var book = await _unitOfWork.Books.GetByIdAsync(id);
            if (book == null) return false;

            _unitOfWork.Books.Delete(book);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Entity'den DTO'ya dönüşüm (Mapping)
        /// 
        /// NOT: Büyük projelerde AutoMapper gibi kütüphaneler kullanılır
        /// Burada öğretici amaçlı manuel mapping yapıyoruz
        /// </summary>
        
        private static BookDto MapToDto(Book book)
        {
            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                // ISBN = book.ISBN,
                Price =book.Price,
                AuthorId = book.AuthorId,
                AuthorName = book.Author?.Name,
                CreatedAt = book.CreatedAt
            };
        }
    }
}
