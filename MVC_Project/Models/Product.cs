using System;
using System.Collections.Generic;

namespace MVC_Project.Models;

public partial class Product
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public int? BrandId { get; set; }

    public string Name { get; set; } = null!;

    public string? ShortDescription { get; set; }

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<ProductColor> ProductColors { get; set; } = new List<ProductColor>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<ProductProperty> ProductProperties { get; set; } = new List<ProductProperty>();

    public virtual ICollection<ProductSize> ProductSizes { get; set; } = new List<ProductSize>();
}
