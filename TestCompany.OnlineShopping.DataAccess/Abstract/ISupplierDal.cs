using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Core.DataAccess;
using TestCompany.OnlineShopping.Entities.Concrete;
using TestCompany.OnlineShopping.Entities.ContextTypes;

namespace TestCompany.OnlineShopping.DataAccess.Abstract
{
    public interface ISupplierDal:IEntityRepository<Supplier>
    {
        List<SupplierDetail> GetSupplierDetails();
    }
}
