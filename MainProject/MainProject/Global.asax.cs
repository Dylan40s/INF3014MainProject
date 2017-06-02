using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using MainProject.Models;

namespace MainProject
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //set initialize the product data base if we chose to do it this way
            Database.SetInitializer(new ProductDatabaseInitializer());
            RegisterCustomRoutes(RouteTable.Routes);
        }
        void RegisterCustomRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
            "ProductsByCategoryRoute",
            "Product/{categoryName}",
            "~/ProductShow.aspx"
            );
            routes.MapPageRoute(
            "ProductByNameRoute",
            "Product/{productName}",
            "~/ProductDetails.aspx"
            );
            routes.MapPageRoute(
            "ProductFilter",
            "Product/{productSearch}",
            "~/ProductShow.aspx"
            );
        }

    }
}