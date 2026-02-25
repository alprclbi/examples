using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Core.DTOs;

/// <summary>
/// Yazar DTO'ları
/// </summary>

    //Yazar bilgilerini döndürmek için kullanılan DTO
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Country { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int BookCount { get; set; } // Yazarın yazdığı kitap sayısı
    }

    // Yazarı kitaplarıyla bilrikte döndürmek için DTO
    public class AuthorWithBooksDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Country { get; set; }
        public DateTime? CreatedAt { get; set; }
        public List<BookDto> Books { get; set; } = new();
    }

    // Yeni yazar ekleme için kullanılan DTO
    public class CreateAuthorDto
    {
        public string Name { get; set; } = string.Empty;
        public string? Country { get; set; }
    }

    // Yazar güncellem için kullanılan DTO
    public class UpdateAuthorDto
    {
        public string Name { get; set; } = string.Empty;
        public string? Country { get; set; }
    }

