
using StackExchange.Redis;
using System.ComponentModel.DataAnnotations;

namespace Homework0304.Models
{
    public class OrderDetail
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int OrderID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}