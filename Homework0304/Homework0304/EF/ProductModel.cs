using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Homework0304.EF
{
    public partial class ProductModel : DbContext
    {
        public ProductModel()
            : base("name=ProductModel")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BorrowedBook> BorrowedBooks { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(e => e.BorrowedBooks)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Owner>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Owner)
                .WillCascadeOnDelete(false);
        }
    }
}
