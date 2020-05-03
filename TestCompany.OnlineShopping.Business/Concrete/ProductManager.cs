using System.Collections.Generic;
using TestCompany.Core.Aspects.Postsharp.LogAspects;
using TestCompany.Core.Aspects.Postsharp.TransactionAspects;
using TestCompany.Core.Aspects.Postsharp.ValidationAspects;
using TestCompany.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using TestCompany.OnlineShopping.Business.Abstract;
using TestCompany.OnlineShopping.Business.ValidationRules.FluentValidation;
using TestCompany.OnlineShopping.DataAccess.Abstract;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        //Aspect yazmak deniyor buna. Methodun başında çalışacak Aspect yazdık.
        [FluentValidationAspect(typeof(ProductValidator))]
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        [LogAspect(typeof(DatabaseLogger))]
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p=>p.CategoryID==categoryId);
        }

        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            //Business kodları
            _productDal.Add(product2);
        }
    }
}
