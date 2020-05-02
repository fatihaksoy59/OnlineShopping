using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.Business.Abstract
{
    interface ICustomerService
    {
        List<Customer> GetAll();
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
