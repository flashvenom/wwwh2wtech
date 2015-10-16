using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace H2W_mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Article",
                "article/{slug}",
                new { controller = "News", action = "Display" }
            );

            routes.MapRoute(
                "Product",
                "product/{category}/{productid}",
                new { controller = "Product", action = "Show" }
            );

            routes.MapRoute(
                "Category",
                "category/{category}",
                new { controller = "Products", action = "Category" }
            );

            routes.MapRoute(
                "linear-motor-product-selector",
                "linear-motor-product-selector/",
                new { controller = "Home", action = "ProductSelector" }
            );

            routes.MapRoute(
                "Page",
                "page/{pagename}",
                new { controller = "Page", action = "Show" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}