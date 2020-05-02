using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TestCompany.Core.DataAccess.EntityFramewrok;
using TestCompany.OnlineShopping.DataAccess.Abstract;
using TestCompany.OnlineShopping.Entities.Concrete;
using TestCompany.OnlineShopping.Entities.ContextTypes;

namespace TestCompany.OnlineShopping.DataAccess.Concrete.EntityFramework
{
    class EfSupplierDal : EfEntityRepositoryBase<Supplier, NorthwindContext>, ISupplierDal
    {
        public List<SupplierDetail> GetSupplierDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from s in context.Suppliers
                             join c in context.Customers on s.CustomerID equals c.CustomerID
                             select new SupplierDetail
                             {
                                 SupplierID = s.SupplierID,
                                 CustomerID = c.CustomerID,
                                 CustomerName = c.FirstName + " " + c.LastName
                             };
                return result.ToList();
            }
        }
    }
}
