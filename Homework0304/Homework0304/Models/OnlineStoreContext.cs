using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Homework0304.Models
{
    public class OnlineStoreContext : DbContext
    {
        public OnlineStoreContext() : base("name=OnlineStore")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDiscount>()
                .HasKey(pd => new { pd.ProductID, pd.DiscountID });

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderDetails)
                .WithRequired(od => od.Order)
                .HasForeignKey(od => od.OrderID);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.OrderDetails)
                .WithRequired(od => od.Product)
                .HasForeignKey(od => od.ProductID);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.ProductDiscounts)
                .WithRequired(pd => pd.Product)
                .HasForeignKey(pd => pd.ProductID);

            modelBuilder.Entity<Discount>()
                .HasMany(d => d.ProductDiscounts)
                .WithRequired(pd => pd.Discount)
                .HasForeignKey(pd => pd.DiscountID);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithRequired(o => o.User)
                .HasForeignKey(o => o.UserID);

            base.OnModelCreating(modelBuilder);
        }


    }
}