using System;
using System.Collections.Generic;
using System.Linq;
using MarketService;

namespace MarketService
{
    public static class ProductManagement
    {
        public static List<ProductDTO> GetProducts()
        {
            using (var db = new MarketModel())
            {
                return db.Products.Select(p => new ProductDTO
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    Description = p.Description,
                    Quantity = p.Quantity,
                }).ToList();
            }
        }

        public static Response CreateOrUpdateProduct(ProductDTO product)
        {
            try
            {
                using (var db = new MarketModel())
                {
                    Product p = db.Products.FirstOrDefault(i => i.Id == product.Id) ?? new Product();
                    p.ProductName = product.ProductName;
                    p.Description = product.Description;
                    p.Quantity = product.Quantity;

                    if (p.Id == 0)
                        db.Products.Add(p);

                    db.SaveChanges();

                    return new Response { Success = true, Message = p.Id == 0 ? "Successfully added product" : "Product updated successfully" };
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
                    Product st = db.Products.FirstOrDefault(i => i.Id == code);
                    if (st == null)
                        throw new Exception($"Cannot find product with Id {id}!");

                    db.Products.Remove(st);
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
