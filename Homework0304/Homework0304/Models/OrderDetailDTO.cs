using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework0304.Models
{
    public class OrderDetailDTO
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}