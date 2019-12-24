using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           
            routes.MapRoute(
              name: "Product Category",
              url: "product/{metatitle}-{cateId}",
              defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional },
              namespaces: new[] { "OnlineShop.Controllers" }
              );

            routes.MapRoute(
             name: "Product Detail",
             url: "detail/{metatitle}-{id}",
             defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
             namespaces: new[] { "OnlineShop.Controllers" }
             );

            routes.MapRoute(
            name: "About",
            url: "about",
            defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional },
            namespaces: new[] { "OnlineShop.Controllers" }
            );

            routes.MapRoute(
         name: "Cart",
         url: "cart",
         defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional },
         namespaces: new[] { "OnlineShop.Controllers" }
     );

            routes.MapRoute(
       name: "Login",
       url: "login",
       defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional },
       namespaces: new[] { "OnlineShop.Controllers" }
   );

            routes.MapRoute(
        name: "Register",
        url: "register",
        defaults: new { controller = "User", action = "Register", id = UrlParameter.Optional },
        namespaces: new[] { "OnlineShop.Controllers" }
    );

            routes.MapRoute(
            name: "Add Cart",
            url: "add-to-cart",
            defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
            namespaces: new[] { "OnlineShop.Controllers" }
            );

                routes.MapRoute(
            name: "Payment",
            url: "payment",
            defaults: new { controller = "Cart", action = "Payment", id = UrlParameter.Optional },
            namespaces: new[] { "OnlineShop.Controllers" }
                 );

                routes.MapRoute(
              name: "Payment Success",
              url: "success",
              defaults: new { controller = "Cart", action = "Success", id = UrlParameter.Optional },
              namespaces: new[] { "OnlineShop.Controllers" }
                   );

            routes.MapRoute(
                 name: "Default",
                 url: "{controller}/{action}/{id}",
                 defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "OnlineShop.Controllers" }
           );


        }
    }
}
