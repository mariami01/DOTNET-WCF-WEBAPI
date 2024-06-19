using StackExchange.Redis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Homework0304.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}