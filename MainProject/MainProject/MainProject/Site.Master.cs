using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using MainProject.Models;
using System.Web.ModelBinding;
using System.Web.UI.HtmlControls;
using MainProject.Logic;

namespace MainProject
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Product> GetProduct()
        {
            var _db = new MainProject.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            return query;
        }

        public IQueryable<Category> getCatagoy()
        {
            var _db = new MainProject.Models.ProductContext();
            IQueryable<Category> query = _db.Catergories;
            return query;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (ShoppingCartActions usersShoppingCart = new
           ShoppingCartActions())
            {
                string cartStr = string.Format("Cart ({0})",
               usersShoppingCart.GetCount());
                cartCount.InnerText = cartStr;
            }
        }

        public void getSearch(object sender, EventArgs e)
        {
            String[] categories = { "clothing","houseware","stationery","specials" };
            String[] catTypes = { "shirts", "glasses", "pillows", "pants" };
            TextBox productSearchText = (TextBox)FindControl("productSearchText");
            string destination = "";
            if (categories.Contains(productSearchText.Text.ToLower())){
                int index = Array.IndexOf(categories, productSearchText.Text.ToLower()) + 1;
                destination = "~/ProductShow.aspx?CategoryID=" + index;
            }else if (catTypes.Contains(productSearchText.Text.ToLower()))
            {
                int index = Array.IndexOf(catTypes, productSearchText.Text.ToLower()) + 1;
                destination = "~/ProductShow.aspx?ProductSearch=" + index;
            }
            else { destination = "~/ProductDetails.aspx?Description=" + productSearchText.Text; }
            
            //Server.Transfer(destination, false);
            Response.Redirect(destination);
        }

    }
}