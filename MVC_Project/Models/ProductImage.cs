using System;
using System.Collections.Generic;

namespace MVC_Project.Models;

public partial class ProductImage
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public bool IsCurrent { get; set; }

    public bool IsActive { get; set; }

    public virtual Product Product { get; set; } = null!;
}
