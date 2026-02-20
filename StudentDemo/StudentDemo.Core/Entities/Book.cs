using System;
using System.Collections.Generic;

namespace StudentDemo.Core.Entities;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Isbn { get; set; }

    public decimal? Price { get; set; }

    public int? AuthorId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Author? Author { get; set; }
}
