namespace WebApplicationSolution.Models
{
    public class Discount
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal DiscountPercentage { get; set; }
        public DateTime ValidityPeriod { get; set; }
        public string ApplicableCategories { get; set; }
        public List<Product> Products { get; set; }

    }
}
