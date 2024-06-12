using System.Collections.Generic;
using AutoMapper;
using MarketService;
using StoreService;

namespace MarketService {
    public class StoreService : IMarketService {
        private readonly IMapper _mapper;

        public StoreService()
        {
            _mapper = AutoMapperConfig.Configure();
        }

        public List<ProductDTO> GetProducts()
        {
            return ProductManagement.GetProducts();
        }

        public Response CreateProduct(ProductDTO product)
        {
            var productEntity = _mapper.Map<Product>(product);
            return ProductManagement.CreateOrUpdateProduct(product);
        }

        public Response UpdateProduct(ProductDTO product)
        {
            var productEntity = _mapper.Map<Product>(product);
            return ProductManagement.CreateOrUpdateProduct(product);
        }

        public Response DeleteProduct(string id)
        {
            return ProductManagement.DeleteProduct(id);
        }
    }
}
