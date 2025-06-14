﻿using System;
using System.Collections.Generic;

namespace myFirstProject.Models;

public partial class ProductModel
{
    public int ProductModelID { get; set; }

    public string? CatalogDescription { get; set; }

    public Guid rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<ProductModelProductDescription> ProductModelProductDescriptions { get; set; } = new List<ProductModelProductDescription>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
