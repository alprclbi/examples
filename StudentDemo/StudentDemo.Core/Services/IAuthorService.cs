using StudentDemo.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Core.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync();

        Task<AuthorDto?> GetAuthorByIdAsync(int id);

        Task<AuthorWithBooksDto?> GetAuthorWithBooksAsync(int id);

        Task<IEnumerable<AuthorDto>> GetAuthorsByCountryAsync(string country);

        Task<AuthorDto> CreateAuthorAsync(CreateAuthorDto dto);

        Task<AuthorDto?> UpdateAuthorAsync(int id, UpdateAuthorDto dto);

        Task<bool> DeleteAuthorAsync(int id);
    }
}
