using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Core.Entities;

namespace TestCompany.OnlineShopping.Entities.Concrete
{
    public class Supplier:IEntity
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        //Supplier bir customer 'a bağlı olmak zorunda
        public int CustomerID { get; set; }
        //Belki buraya bir join yazılıp Contact Name çekilebilr. Yada context Types'a yazılır.
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
    }
}
