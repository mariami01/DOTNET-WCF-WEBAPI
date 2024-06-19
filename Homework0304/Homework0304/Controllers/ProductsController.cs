using Homework0304.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Homework0304.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        private readonly OnlineStoreContext db = new OnlineStoreContext();

        // GET: api/products
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetProducts()
        {
            var products = db.Products.ToList();
            return Ok(products);
        }

        // GET: api/products/5
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetProduct(int id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}