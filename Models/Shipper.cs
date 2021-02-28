using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Shop.Models
{
    public class Shipper
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public List<Product> Products { get; set; }
    }
}