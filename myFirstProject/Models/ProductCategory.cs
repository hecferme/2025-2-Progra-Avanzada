﻿using System;
using System.Collections.Generic;

namespace myFirstProject.Models;

public partial class ProductCategory
{
    public int ProductCategoryID { get; set; }

    public int? ParentProductCategoryID { get; set; }

    public Guid rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<ProductCategory> InverseParentProductCategory { get; set; } = new List<ProductCategory>();

    public virtual ProductCategory? ParentProductCategory { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
