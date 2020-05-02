using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Core.DataAccess;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
