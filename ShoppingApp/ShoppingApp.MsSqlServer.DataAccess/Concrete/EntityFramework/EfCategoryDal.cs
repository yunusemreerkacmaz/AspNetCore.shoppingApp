using ShoppingApp.Core.DataAccess.EntityFramework;
using ShoppingApp.MsSqlServer.DataAccess.Abstract;
using ShoppingApp.MsSqlServer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.MsSqlServer.DataAccess.Concrete.EntityFramework
{
     public class EfCategorytDal : efEntityRepositoryBase<Category, MsSqlServerContext>, ICategoryDal
     {
     }   
}
