using System;
using System.Runtime.Serialization;

namespace MarketService {
    [DataContract, Serializable]
    public class ProductDTO {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int? Quantity { get; set; }
    }
}