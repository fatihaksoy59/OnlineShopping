using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Core.Entities;

namespace TestCompany.OnlineShopping.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        //Bunu joinli yaz
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }

    }
}
