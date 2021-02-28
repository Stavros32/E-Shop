using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Shop.Data
{
    public class E_ShopContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public E_ShopContext() : base("name=E_ShopContext")
        {
        }

        public System.Data.Entity.DbSet<E_Shop.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<E_Shop.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<E_Shop.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<E_Shop.Models.OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<E_Shop.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<E_Shop.Models.Supplier> Suppliers { get; set; }

        public System.Data.Entity.DbSet<E_Shop.Models.Shipper> Shippers { get; set; }
    }
}
