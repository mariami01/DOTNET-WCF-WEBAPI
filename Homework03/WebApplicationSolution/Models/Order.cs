namespace WebApplicationSolution.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserID { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
