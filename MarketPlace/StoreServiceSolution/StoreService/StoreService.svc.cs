using System.Collections.Generic;
using MarketService;

namespace MarketService {
    public class StoreService : IMarketService {
        public List<ProductDTO> GetProducts() => ProductManagement.GetProducts();

        public Response CreateProduct(ProductDTO product) => ProductManagement.CreateOrUpdateProduct(product);

        public Response UpdateProduct(ProductDTO product) => ProductManagement.CreateOrUpdateProduct(product);

        public Response DeleteProduct(string id) => ProductManagement.DeleteProduct(id);
    }
}
