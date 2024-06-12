using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MarketService;
using StoreService;

namespace MarketService
{

    public static class ProductManagement
    {
        private static readonly IMapper _mapper;

        static ProductManagement()
        {
            _mapper = AutoMapperConfig.Configure();
        }

        public static List<ProductDTO> GetProducts()
        {
            using (var db = new MarketModel())
            {
                var products = db.Products.ToList();
                return _mapper.Map<List<ProductDTO>>(products);
            }
        }

        public static Response CreateOrUpdateProduct(ProductDTO productDto)
        {
            try
            {
                using (var db = new MarketModel())
                {
                    var product = db.Products.FirstOrDefault(i => i.Id == productDto.Id) ?? new Product();
                    _mapper.Map(productDto, product);

                    if (product.Id == 0)
                        db.Products.Add(product);

                    db.SaveChanges();

                    return new Response
                    {
                        Success = true,
                        Message = product.Id == 0 ? "Successfully added product" : "Product updated successfully"
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response { Success = false, Message = ex.Message };
            }
        }

        public static Response DeleteProduct(string id)
        {
            try
            {
                if (!int.TryParse(id, out int code))
                    throw new Exception("Id was not found!");

                using (var db = new MarketModel())
                {
                    var product = db.Products.FirstOrDefault(i => i.Id == code);
                    if (product == null)
                        throw new Exception($"Cannot find product with Id {id}!");

                    db.Products.Remove(product);
                    db.SaveChanges();

                    return new Response { Success = true, Message = "Successfully deleted product" };
                }
            }
            catch (Exception ex)
            {
                return new Response { Success = false, Message = ex.Message };
            }
        }
    }
}