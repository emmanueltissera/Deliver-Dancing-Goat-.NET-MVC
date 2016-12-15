using System.Web.Mvc;
using System.Web.Routing;
using DeliverDancingGoatMVC.Routing;

namespace DeliverDancingGoatMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //http://stackoverflow.com/questions/32565768/change-route-collection-of-mvc6-after-startup

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapCmsRoutes();

            routes.MapRoute(
                name: "AboutRoute",
                url: "about-us",
                defaults: new { controller = "About", action = "Index" }
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
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}