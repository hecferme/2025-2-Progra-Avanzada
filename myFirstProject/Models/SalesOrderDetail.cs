using System;
using System.Collections.Generic;
using myFirstProject.MyCustomValidators;

namespace myFirstProject.Models;

public partial class SalesOrderDetail
{
    public int SalesOrderID { get; set; }

    public int SalesOrderDetailID { get; set; }

    //[IsPrimeNumber (ErrorMessage = "El número debe ser primo.")]
    [PrimeNumberValidator (ErrorMessage ="El número NO debe ser primo.", ShouldBePrime = false)]
    public short OrderQty { get; set; }

    public int ProductID { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal UnitPriceDiscount { get; set; }

    public decimal LineTotal { get; set; }

    public Guid rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual SalesOrderHeader SalesOrder { get; set; } = null!;
}
