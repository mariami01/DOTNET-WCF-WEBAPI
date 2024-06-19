using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Homework0304.Models
{
    public class Discount
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public decimal DiscountPercentage { get; set; }

        [Required]
        public DateTime ValidityPeriod { get; set; }

        [Required]
        public string ApplicableCategories { get; set; }

        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }
    }
}