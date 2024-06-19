using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Homework0304.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductDiscountDTO> ProductDiscounts { get; set; }
    }
}