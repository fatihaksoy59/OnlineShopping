using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.OnlineShopping.Business.Abstract;
using TestCompany.OnlineShopping.Business.Concrete;
using TestCompany.OnlineShopping.DataAccess.Abstract;
using TestCompany.OnlineShopping.DataAccess.Concrete.EntityFramework;

namespace TestCompany.OnlineShopping.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();

            //Client side için bunun içinde bulunduğu klasöre ValidationModule diye bir class ekleyip işlem yapabilrisn.
        }
    }
}
