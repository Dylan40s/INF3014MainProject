using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MainProject.Models;
using System.Web.ModelBinding;
using System.Web.UI.HtmlControls;

namespace MainProject
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /* public IQueryable<Product> GetProduct([QueryString("ProductID")] int? productId)
          {
              var _db = new MainProject.Models.ProductContext();
              IQueryable<Product> query = _db.Products;
              if (productId.HasValue && productId > 0)
              {
                  query = query.Where(p => p.ProductID == productId);
              }

              return query;
          }*/

        public IQueryable<Product> GetProduct([QueryString("ProductName")] string productName, [QueryString("Description")] string description)
        {
            var _db = new MainProject.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (!String.IsNullOrEmpty(productName))
            {
                query = query.Where(p =>
                String.Compare(p.ProductName.ToLower(), productName.ToLower()) == 0);
            }
            if (!String.IsNullOrEmpty(description))
            {
                query = query.Where(p =>
                String.Compare(p.Description.ToLower(), description.ToLower()) == 0);
            }
            /* if (categoryID.HasValue && categoryID > 0)
             {
                 Image helpImage = (Image)productDetail.FindControl("imagePlaceHolder");
                 Label helpLabel = (Label)FindControl("helpText");
                 switch (categoryID ?? default(int)){
                     case 1:
                         helpImage.ImageUrl = "~/Images/clothingHelp.png";
                         helpLabel.Text = "Clothing examples";
                         break;
                     case 2:
                         helpImage.ImageUrl = "~/Images/housewareHelp.png";
                         helpLabel.Text = "Houseware examples";
                         break;
                     case 3:
                         helpImage.ImageUrl = "~/Images/stationeryHelp.png";
                         helpLabel.Text = "Stationery examples";
                         break;
                     case 4:
                         helpImage.ImageUrl = "~/Images/specialsHelp.png";
                         helpLabel.Text = "Specials examples";
                         break;
                 }
             }*/
            return query;
        }

        public void addImage_click(object sender, EventArgs e)
        {
            FileUpload ProductImage = (FileUpload)productDetail.FindControl("ProductImage");
            Boolean fileOK = false;
            String path = Server.MapPath("~/Images/AddedImages/");

            if (ProductImage.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(ProductImage.FileName).ToLower();
                String[] allowedExtensions = { ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }
            if (fileOK)
            {
                Image imagePlaceHolder = (Image)productDetail.FindControl("imagePlaceHolder");
                ProductImage.PostedFile.SaveAs(path + ProductImage.FileName);
                imagePlaceHolder.ImageUrl = "~/Images/AddedImages/" + ProductImage.FileName;
            }
            else
            {
                //TODO add message to show that file was the incorrect input
            }

        }

        public void addToCart(object sender, EventArgs e)
        {

        }

        public object helpImageSelect(int categoryID)
        {
            if ( categoryID > 0)
            {
                Image helpImage = (Image)productDetail.FindControl("helpImage");
                Label helpLabel = (Label)productDetail.FindControl("helpText");
                switch (categoryID )
                {
                    case 1:
                        helpImage.ImageUrl = "~/Images/clothingHelp.png";
                        helpLabel.Text = "Clothing examples";
                        break;
                    case 2:
                        helpImage.ImageUrl = "~/Images/housewareHelp.png";
                        helpLabel.Text = "Houseware examples";
                        break;
                    case 3:
                        helpImage.ImageUrl = "~/Images/stationeryHelp.png";
                        helpLabel.Text = "Stationery examples";
                        break;
                    case 4:
                        helpImage.ImageUrl = "~/Images/specialsHelp.png";
                        helpLabel.Text = "Specials examples";
                        break;
                }

            }
            return this;
        }
    }
}