using ShoppingApp.MsSqlServer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.MsSqlServer.Business.Abstract
{
   public interface IProductService
    {
       public List<Product> GetAll();
        public List<Product> GetByCategory(int categoryId);
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(int productId);
        public Product GetById(int ProductId);
    }
}
