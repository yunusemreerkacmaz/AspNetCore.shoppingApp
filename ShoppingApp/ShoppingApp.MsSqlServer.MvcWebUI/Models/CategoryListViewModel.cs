using ShoppingApp.MsSqlServer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.MsSqlServer.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> categories { get; set; }
        public int currentCategory { get; internal set; }
    }
}
