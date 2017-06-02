using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MainProject.Models;
using System.Web.ModelBinding;

namespace MainProject
{
    public partial class ProductShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /* public IQueryable<Product> GetProducts( [QueryString("categoryID")] int? categoryId, [RouteData] string productSearch)
         {
            // categoryName = "Shirts";
             var _db = new MainProject.Models.ProductContext();
             IQueryable<Product> query = _db.Products;
             if (categoryId.HasValue && categoryId > 0)
             {
                 query = query.Where(p => p.CategoryID == categoryId);
             }
             if (!String.IsNullOrEmpty(productSearch))
             {
                 query = query.Where(p => String.Compare(p.ProductSearch, productSearch) == 0);
             }
             return query;
         }

         public IQueryable<Product> GetProduct([QueryString("ProductID")] int? productId, [RouteData] string productSearch)
         {
             var _db = new MainProject.Models.ProductContext();
             IQueryable<Product> query = _db.Products;
             if (productId.HasValue && productId > 0)
             {
                 query = query.Where(p => p.ProductID == productId);
             }
             else if (!String.IsNullOrEmpty(productSearch))
             {
                 query = query.Where(p =>
                 String.Compare(p.ProductSearch, productSearch) == 0);
             }
             else
             {
                 query = null;
             }
             return query;
         }*/

         public IQueryable<Product> GetProducts([QueryString("CategoryID")] int? categoryId, [QueryString("ProductSearch")] string ProductSearch)
         {
             var _db = new MainProject.Models.ProductContext();
             IQueryable<Product> query = _db.Products;
             if (categoryId.HasValue && categoryId > 0)
             {
                 query = query.Where(p => p.CategoryID == categoryId);
             }else if (!String.IsNullOrEmpty(ProductSearch))
            {
                query = query.Where(p => String.Compare(p.ProductSearch, ProductSearch) == 0);
            }
            else
            {
                query = null;
            }

            return query;
         }
        

        /* public IQueryable<Product> GetProducts([QueryString("ProductID")] int? productId, [RouteData] string productSearch)
         {
             var _db = new MainProject.Models.ProductContext();
             IQueryable<Product> query = _db.Products;

             if (!String.IsNullOrEmpty(productSearch))
             {
                 query = query.Where(p =>String.Compare(p.ProductSearch, productSearch) == 0);
             }
             else
             {
                 query = null;
             }
             return query;
         }*/

    }
}