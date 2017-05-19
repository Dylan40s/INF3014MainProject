using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MainProject.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("MainProject"/*name goes in here*/) { }
        public DbSet<Category> Catergories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}