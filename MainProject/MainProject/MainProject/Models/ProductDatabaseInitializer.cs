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
            GetCategory().ForEach(c => context.Catergories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
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
                    CategoryName = "Clothes",
                    Description ="Clothes of any kind"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Homeware",
                    Description ="Products to be used at home"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Stationery",
                    Description ="Products to use at the office"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "General",
                    Description ="General products"
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
                    ProductName = "vNeck",
                    ProductSearch = "Shirts",
                    Description = "V Neck",
                    ImagePath = "vNeck.png",
                    UnitPrice = 100,
                    CategoryID = 1,
                    Colour = "B",
                    Custom = true,

                }

            };
            return products;
        }
    }
}