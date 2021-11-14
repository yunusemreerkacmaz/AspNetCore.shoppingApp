using ShoppingApp.MsSqlServer.Business.Abstract;
using ShoppingApp.MsSqlServer.DataAccess.Abstract;
using ShoppingApp.MsSqlServer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.MsSqlServer.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public List<Category> GetAll()
        {
           return _categoryDal.GetList();
        }

 
    }
}
