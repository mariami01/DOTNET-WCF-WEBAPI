using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework0304.Models
{
    public class DiscountcsDTO
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public float DiscountPercentage { get; set; }
        public DateTime ValidityPeriod { get; set; }
        public string ApplicableCategories { get; set; }
    }
}