using ShoppingApp.MsSqlServer.Entities.Concrete;
using System.Collections.Generic;

namespace ShoppingApp.MsSqlServer.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}