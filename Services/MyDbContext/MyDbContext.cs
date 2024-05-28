using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MyDbContext
{
    public class MyContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("MyDatabase");
            
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Detail> Details { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(product => product.Category)
                .WithMany(category => category.Products);

            modelBuilder.Entity<Bill>()
                .HasOne(bill => bill.User);
            //.WithMany(user => user.Bills);

            modelBuilder.Entity<Bill>()
                .HasOne<Detail>();


            modelBuilder.Entity<Detail>()
                .HasOne(detail => detail.Bill)
                .HasForeignKey(x => x.BillId);

            modelBuilder.Entity<Detail>()
            .HasNoKey(); 
            
        }
    }
}
