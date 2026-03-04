using Microsoft.AspNetCore.Mvc;
using StudentDemo.Core.DTOs;
using StudentDemo.Core.Services;

namespace StudentDemo.API.Controllers;

// <summary>
// AuthorsController - Yazar API Endpoint'lerini yöneten controller.
// SOLID: Single Resposiblity Principle + Dependency Inversion
// </summary>

[ApiController]
[Route("api/[controller]")]
public class AuthorsController : Controller
{
    private readonly IAuthorService _authorService;

    public AuthorsController(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    /// <summary>
    /// Tüm yazarları getirir
    /// GET: api/authors
    /// </summary>

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AuthorDto>>> GetAll()
    {
        var authors = await _authorService.GetAllAuthorsAsync();
        return Ok(authors);
    }

    /// <summary>
    /// ID'ye göre yazar getirir
    /// GET: api/authors/5
    /// </summary>

    [HttpGet("{id}")]
    public async Task<ActionResult<AuthorDto>> GetById(int id)
    {
        var author = await _authorService.GetAuthorByIdAsync(id);
        if (author == null)
            return NotFound(new { message = $"Yazar bulunamadi. ID: {id}" });
        return Ok(author);
    }

    /// <summary>
    /// Yazarın kitaplarını getirir
    /// GET: api/authors/5/books
    /// </summary>

    [HttpGet("{id}/books")]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetAuthorWithBooks(int id)
    {
        var author = await _authorService.GetAuthorWithBooksAsync(id);
        if (author == null)
            return NotFound(new { message = $"Yazar bulunamadi. ID: {id}" });
        return Ok(author);
    }

    /// <summary>
    /// Ülkeye göre yazarları getirir
    /// GET: api/authors/country/Türkiye
    /// </summary>

    [HttpGet("country/{country}")]
    public async Task<ActionResult<IEnumerable<AuthorDto>>> GetByCountry(string country)
    {
        var authors = await _authorService.GetAuthorsByCountryAsync(country);
        return Ok(authors);
    }
    /// <summary>
    /// Yeni yazar ekler
    /// POST: api/authors
    /// Body: { "name": "Yazar Adı", "country": "Ülke" }
    /// </summary>

    [HttpPost]
    public async Task<ActionResult<AuthorDto>> Create([FromBody] CreateAuthorDto dto)
    {
        if (string.IsNullOrEmpty(dto.Name))
            return BadRequest(new { message = "Yazar adı zorunludur." });

        var author = await _authorService.CreateAuthorAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = author.Id }, author);
    }
    /// <summary>
    /// Yazar günceller
    /// PUT: api/authors/5
    /// </summary>

    [HttpPut("{id}")]
    public async Task<ActionResult<AuthorDto>> Update(int id, [FromBody] UpdateAuthorDto dto)
    {
        if (string.IsNullOrEmpty(dto.Name))
            return BadRequest(new { message = "Yazar adı zorunludur." });

        var author = await _authorService.UpdateAuthorAsync(id, dto);

        if (author == null)
            return NotFound(new { message = $"Yazar bulunamadi. ID: {id}" });

        return Ok(author);
    }

    /// <summary>
    /// Yazar siler
    /// DELETE: api/authors/5
    /// </summary>

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _authorService.DeleteAuthorAsync(id);

        if (!result)
            return NotFound(new { message = $"Yazar bulunamadi. ID: {id}" });
        return NoContent();
    }
}
