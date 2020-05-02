using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Core.Entities;

namespace TestCompany.OnlineShopping.Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string NationalIdentityNumber { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
