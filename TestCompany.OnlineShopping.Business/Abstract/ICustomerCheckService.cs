using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.Business.Abstract
{
    public interface ICustomerCheckService
    {
        bool IsRealPerson(Customer customer);
    }
}
