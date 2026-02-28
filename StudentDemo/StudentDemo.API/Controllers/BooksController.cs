using Microsoft.AspNetCore.Mvc;
using StudentDemo.Core.DTOs;
using StudentDemo.Core.Services;

namespace StudentDemo.API.Controllers;

/// <summary>
/// BooksController - Kitap API Endpoint'leri
/// 
/// SOLID Prensipleri:
/// - Single Responsibility: Sadece HTTP isteklerini yönetir
/// - Dependency Inversion: IBookService interface'ine bağımlı
/// 
/// Controller'ın görevi:
/// - HTTP isteklerini almak
/// - Parametreleri validate etmek
/// - Service'i çağırmak
/// - Uygun HTTP response döndürmek
/// 
/// Controller'da iş mantığı OLMAMALI!
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class BooksController : Controller
{
    private readonly IBookService _bookService;

    // Constructor Injection
    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }
    /// <summary>
    /// Tüm kitapları getirir
    /// GET: api/books
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetAll()
    {
        var books = await _bookService.GetAllBooksAsync();
        return Ok(books);
    }
    /// <summary>
    /// ID'ye göre kitap getirir
    /// GET: api/books/5
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<BookDto>> GetById(int id)
    {
        var book = await _bookService.GetBookByIdAsync(id);
        if (book == null)
            return NotFound(new { message = $"Kitap bulunamadi. ID: {id}" });
        return Ok(book);
    }

    /// <summary>
    /// ISBN'e göre kitap getirir
    /// GET: api/books/isbn/978-1234567890
    /// </summary>

    [HttpGet("isbn/{isbn}")]
    public async Task<ActionResult<BookDto>> GetByIsbn(string isbn)
    {
        var book = await _bookService.GetBookByIsbnAsync(isbn);
        if (book == null)
            return NotFound(new { message = $"Kitap bulunamadi. ISBN: {isbn}" });
        return Ok(book);
    }

    /// <summary>
    /// Yeni kitap ekler
    /// POST: api/books
    /// Body: { "title": "Kitap Adı", "isbn": "...", "price": 50.00, "authorId": 1 }
    /// </summary>

    [HttpPost]
    public async Task<ActionResult<BookDto>> Create([FromBody] CreateBookDto dto)
    {
        // basit validation
        if (string.IsNullOrEmpty(dto.Title))
            return BadRequest(new { message = "Kitap basligi zorunludur." });

        var book = await _bookService.CreateBookAsync(dto);

        // 201 created + Location header
        return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
    }

    /// <summary>
    /// Kitap günceller
    /// PUT: api/books/5
    /// Body: { "title": "Yeni Başlık", ... }
    /// </summary>
    
    [HttpPut("{id}")]
    public async Task<ActionResult<BookDto>> Update(int id, [FromBody] UpdateBookDto dto)
    {
        if(string.IsNullOrEmpty(dto.Title))
            return BadRequest(new { message = "Kitap basligi zorunludur." });

        var book = await _bookService.UpdateBookAsync(id, dto);
        if (book == null)
            return NotFound(new { message = $"Kitap bulunamadi. ID: {id}" });
        return Ok(book);
    }

    /// <summary>
    /// Kitap siler
    /// DELETE: api/books/5
    /// </summary>
    
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _bookService.DeleteBookAsync(id);
        if (!result)
            return NotFound(new { message = $"Kitap bulunamadi. ID: {id}" });
        return NoContent(); // 204 No Content
    }
}
