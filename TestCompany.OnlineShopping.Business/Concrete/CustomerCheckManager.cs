using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.OnlineShopping.Business.Abstract;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.Business.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool IsRealPerson(Customer customer)
        {
            //Bunu test ortamında Mernise gitmesin diye yazdık. 
            //Bu olaya adapter design pattern denir.
            return true;
        }

    }
}
