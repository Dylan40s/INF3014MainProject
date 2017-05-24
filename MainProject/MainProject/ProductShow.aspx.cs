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
        public IQueryable<Product> GetProducts( [QueryString("id")] int? categoryId, [RouteData] string categoryName)
        {
           // categoryName = "Shirts";
            var _db = new MainProject.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            if (!String.IsNullOrEmpty(categoryName))
            {
                query = query.Where(p => String.Compare(p.Category.CategoryName, categoryName) == 0);
            }
            return query;
        }

        public void tryThis(object sender, EventArgs e)
        {
           string route =  GetRouteUrl("ProductsByCategoryRoute", new { categoryID = 1 });
            string hello = "test";
        }
    }
}