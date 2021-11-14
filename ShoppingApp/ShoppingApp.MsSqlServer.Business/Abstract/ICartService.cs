using ShoppingApp.MsSqlServer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.MsSqlServer.Business.Abstract
{
    public interface ICartService
    {
       public void AddToCart(Cart cart, Product product);
        public void RemoveFromCart(Cart cart,int productId);
       public List<CartLine> List(Cart cart);
        
    }
}
