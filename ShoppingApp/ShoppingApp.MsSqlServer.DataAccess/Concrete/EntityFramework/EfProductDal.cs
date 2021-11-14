using ShoppingApp.MsSqlServer.DataAccess.Abstract;
using ShoppingApp.MsSqlServer.Entities.Concrete;
using ShoppingApp.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.MsSqlServer.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : efEntityRepositoryBase<Product, MsSqlServerContext>, IProductDal
    {
    }

}
