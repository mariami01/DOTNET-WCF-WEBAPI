using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework0304.Models
{
    public class ProductDiscount
    {
        [Key, Column(Order = 1)]
        public int ProductID { get; set; }

        [Key, Column(Order = 2)]
        public int DiscountID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Discount Discount { get; set; }
    }
}