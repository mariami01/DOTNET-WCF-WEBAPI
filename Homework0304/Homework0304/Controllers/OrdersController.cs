using Homework0304.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;


namespace Homework0304.Controllers
{
    [System.Web.Http.RoutePrefix("api/orders")]
    public class OrdersController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IEnumerable<OrderDTO> GetOrders()
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OnlineStore"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Orders", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    orders.Add(new OrderDTO
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                        UserID = Convert.ToInt32(reader["UserID"])
                    });
                }
            }
            return orders;
        }

    }
}