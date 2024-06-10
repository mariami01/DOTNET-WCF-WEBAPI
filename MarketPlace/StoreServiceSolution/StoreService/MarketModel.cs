using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MarketService {
    public partial class MarketModel : DbContext {
        public MarketModel()
            : base("Server=LAPTOP-M9NIMU9D\\MSSQLSERVER02;Database=ProductDb;Trusted_Connection=True") {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            Console.WriteLine("*PEACE*");
        }
    }
}
