using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MainProject.Models
{
    // code used if the database needs to be created and filled with dummy data, can be used 
    // if we want to add lots of data
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            
        }

        private static List<Category> GetCategory()
        {
            var categories = new List<Category>
            {
                // Add new code here to create new categories for all things in shop
                //eg
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Shirt"
                },
            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "V-Neck",
                    Description = "V-Neck, colour",
                    ImagePath = "v_neck.png",
                    UnitPrice = 100,
                    CategoryID = 1,
                    Colour = "Black",
                    Custom = true,

                }

            };
            return products;
        }
    }
}