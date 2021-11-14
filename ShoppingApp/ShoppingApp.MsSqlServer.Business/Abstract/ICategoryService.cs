using ShoppingApp.MsSqlServer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.MsSqlServer.Business.Abstract
{
   public interface ICategoryService
    {
       public List<Category> GetAll();

    }
}
