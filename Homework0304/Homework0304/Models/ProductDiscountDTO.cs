using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework0304.Models
{
    public class ProductDiscountDTO
    {
        [Key]
        public int ProductID { get; set; }
        public int DiscountID { get; set; }
        public string ProductName { get; set; }
        public string DiscountDescription { get; set; }
        public decimal DiscountPercentage { get; set; }
        public DateTime ValidityPeriod { get; set; }
    }
}