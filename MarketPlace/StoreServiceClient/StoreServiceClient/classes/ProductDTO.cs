using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketServiceClientApp {
    [Serializable]
    public class ProductDTO {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
    }
}
