using ShoppingApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.MsSqlServer.Entities.Concrete
{
   public class Category :IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
