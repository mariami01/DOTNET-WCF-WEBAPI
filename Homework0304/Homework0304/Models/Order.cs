using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework0304.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int UserID { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual User User { get; set; }

    }
}