using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Core.DTOs;
/// <summary>
/// DTO (Data Transfer Object) Nedir?
/// </summary>

public class BookDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? ISBN { get; set; }
    public decimal? Price { get; set; }
    public int? AuthorId { get; set; }
    public string? AuthorName { get; set; } // Navigation property yerine sadece isim
    public DateTime? CreatedAt { get; set; }
}

// Yeni kitap ekleme için kullanılan DTO

public class CreateBookDto
{
    public string Title { get; set; } = string.Empty;
    public string? ISBN { get; set; }
    public decimal? Price { get; set; }
    public int? AuthorId { get; set; }
}

// Kitap güncelleme için kullanılan DTO

public class UpdateBookDto
{
    public string Title { get; set; } = string.Empty;
    public string? ISBN { get; set; }
    public decimal? Price { get; set; }
    public int? AuthorId { get; set; }
 
}