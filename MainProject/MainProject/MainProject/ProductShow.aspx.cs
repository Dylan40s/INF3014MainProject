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

         public IQueryable<Product> GetProducts([QueryString("CategoryID")] int? categoryId, [QueryString("ProductSearch")] string ProductSearch, [QueryString("Price")] int? Price, [QueryString("Colour")] string Colour)
         {
             var _db = new MainProject.Models.ProductContext();
             IQueryable<Product> query = _db.Products;
             if (categoryId.HasValue && categoryId > 0)
             {
                RadioButtonList radio = (RadioButtonList)scaleID.FindControl("categorySelect");
                radio.SelectedIndex = (categoryId ?? default(int) )-1;
                query = query.Where(p => p.CategoryID == categoryId);
             }if (!String.IsNullOrEmpty(ProductSearch))
            {
                query = query.Where(p => String.Compare(p.ProductSearch.ToLower(), ProductSearch.ToLower()) == 0);
            }if (Price.HasValue && Price > 0)
            {
                query = query.Where(p => p.UnitPrice <= Price);
            }if (Price.HasValue && Price > 0)
            {
                query = query.Where(p => p.UnitPrice <= Price);
            }
            if (!String.IsNullOrEmpty(Colour))
            {
                query = query.Where(p => String.Compare(p.Colour, Colour) == 0);

            }

                return query;
         }
        
        public void applyFilters(object sender, EventArgs e)
        {
            RadioButtonList radio = (RadioButtonList)scaleID.FindControl("categorySelect");
            RadioButtonList radioColour = (RadioButtonList)scaleID.FindControl("colourSelect");
            TextBox textScale = (TextBox)scaleID.FindControl("textScale");
            string convertString = textScale.Text.Substring(1, textScale.Text.Length-1);
            int price = Convert.ToInt32(convertString);
            string destination;
            if (colourSelect.SelectedIndex == -1)
                 destination = "~/ProductShow.aspx?CategoryID=" + Convert.ToString(radio.SelectedIndex+1) + "&Price=" + Convert.ToString(price);
            else
                destination = "~/ProductShow.aspx?CategoryID=" + Convert.ToString(radio.SelectedIndex + 1) + "&Price=" + Convert.ToString(price) + "&Colour=" + radio.SelectedItem;
            //Server.Transfer(destination, false);
            Response.Redirect(destination);
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