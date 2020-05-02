using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.OnlineShopping.Business.Abstract;
using TestCompany.OnlineShopping.DataAccess.Abstract;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.Business.Concrete
{


    class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        private ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerDal customerDal, ICustomerCheckService customerCheckService)
        {
            _customerDal = customerDal;
            _customerCheckService = customerCheckService;
        }

        public void Add(Customer customer)
        {
            if (!_customerCheckService.IsRealPerson(customer))
                throw new Exception("Not a Valid Person");

            _customerDal.Add(customer);

        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }
        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
        public List<Customer> GetAll()
        {
            return _customerDal.GetList();
        }

    }
}
