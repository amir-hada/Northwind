using System;
using System.Collections.Generic;

namespace Northwind.Sample;

public partial class Category
{
    public int CategoryID { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
