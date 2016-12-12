using System.Web.Mvc;
using System.Web.Routing;

namespace DeliverDancingGoatMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "AboutRoute",
                url: "about-us",
                defaults: new { controller = "About", action = "Index" }
            );

            routes.MapRoute(
                name: "ArticlesDetailRoute",
                url: "articles/{id}",
                defaults: new { controller = "Articles", action = "Show" }
            );

            routes.MapRoute(
                name: "ArticlesRoute",
                url: "articles",
                defaults: new { controller = "Articles", action = "Index"}
            );

            routes.MapRoute(
                name: "BrewersRoute",
                url: "product-catalog/brewers",
                defaults: new { controller = "Brewers", action = "Index" }
            );

            routes.MapRoute(
                name: "CafesRoute",
                url: "cafes",
                defaults: new { controller = "Cafes", action = "Index" }
            );

            routes.MapRoute(
                name: "CoffeesRoute",
                url: "product-catalog/coffees",
                defaults: new { controller = "Coffees", action = "Index" }
            );

            routes.MapRoute(
                name: "ContactsRoute",
                url: "contacts",
                defaults: new { controller = "Contacts", action = "Index" }
            );

            routes.MapRoute(
                name: "ProductsCoffeesRoute",
                url: "coffee/{id}",
                defaults: new { controller = "Product", action = "Detail" }
            );

            routes.MapRoute(
                name: "ProductsBrewersRoute",
                url: "brewers/{id}",
                defaults: new { controller = "Product", action = "Detail" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}