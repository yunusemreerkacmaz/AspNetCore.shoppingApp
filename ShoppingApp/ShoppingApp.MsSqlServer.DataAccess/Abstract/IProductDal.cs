using ShoppingApp.Core.DataAccess;
using ShoppingApp.MsSqlServer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.MsSqlServer.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        // Custom Operations
        
    }
}
