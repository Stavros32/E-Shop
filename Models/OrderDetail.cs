using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Shop.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int? ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float? Discount { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}