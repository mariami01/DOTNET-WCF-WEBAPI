using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework0304.Models
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserID { get; set; }
    }
}