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


    }
}