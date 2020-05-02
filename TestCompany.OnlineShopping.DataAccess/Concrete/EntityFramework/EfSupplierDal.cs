using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Core.DataAccess.EntityFramewrok;
using TestCompany.OnlineShopping.DataAccess.Abstract;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.DataAccess.Concrete.EntityFramework
{
    class EfSupplierDal:EfEntityRepositoryBase<Supplier,NorthwindContext>,ISupplierDal
    {
    }
}
