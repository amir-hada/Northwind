using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Northwind.Sample;

public partial class Alphabetical_list_of_product : IEntity<int>
{
    public int ProductID { get; set; }

    public string ProductName { get; set; } = null!;
    public int? SupplierID { get; set; }
    public int? CategoryID { get; set; }
    public string? QuantityPerUnit { get; set; }
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }
    public short? UnitsOnOrder { get; set; }
    public short? ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
    public string CategoryName { get; set; } = null!;

    // IEntity<int> implementation
    public int Id => ProductID;

    // IEntity implementation
    public object[] GetKeys()
    {
        return new object[] { ProductID };
    }
}
