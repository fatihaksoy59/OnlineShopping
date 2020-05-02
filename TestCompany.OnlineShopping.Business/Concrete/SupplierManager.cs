using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.OnlineShopping.Business.Abstract;
using TestCompany.OnlineShopping.DataAccess.Abstract;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.Business.Concrete
{
    class SupplierManager : ISupplierService
    {
        ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }
        public void Add(Supplier supplier)
        {
            _supplierDal.Add(supplier);
        }
        public void Update(Supplier supplier)
        {
            _supplierDal.Update(supplier);
        }
        public void Delete(Supplier supplier)
        {
            _supplierDal.Delete(supplier);
        }

        public List<Supplier> GetAll()
        {
            return _supplierDal.GetList();
        }
    }
}
