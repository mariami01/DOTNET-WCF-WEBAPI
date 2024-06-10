namespace WebApplicationSolution.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
