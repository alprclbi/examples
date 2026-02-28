using StudentDemo.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Core.Services
{
    public interface IBookService
    {
        Task<IEnumerable<BookDto>> GetAllBooksAsync();

        Task<BookDto?> GetBookByIdAsync(int id);

        Task<IEnumerable<BookDto>> GetBooksByAuthorIdAsync(int authorId);

        Task<BookDto?> GetBookByIsbnAsync(string isbn);

        Task<BookDto> CreateBookAsync(CreateBookDto dto);

        Task<BookDto?> UpdateBookAsync(int id, UpdateBookDto dto);

        Task<bool> DeleteBookAsync(int id);
    }
}
