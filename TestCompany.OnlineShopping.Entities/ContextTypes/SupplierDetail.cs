using System;
using System.Collections.Generic;
using System.Text;

namespace TestCompany.OnlineShopping.Entities.ContextTypes
{
    public class SupplierDetail
    {
        public int SupplierID { get; set;}
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
    }
}
