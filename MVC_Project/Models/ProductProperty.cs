using System;
using System.Collections.Generic;

namespace MVC_Project.Models;

public partial class ProductProperty
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string Attr { get; set; } = null!;

    public string Value { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
