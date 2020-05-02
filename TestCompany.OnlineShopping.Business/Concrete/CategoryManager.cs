using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.OnlineShopping.Business.Abstract;
using TestCompany.OnlineShopping.DataAccess.Abstract;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.Business.Concrete
{
    class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }


    }
}
