using System.Collections.Generic;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Routing;
using System.Web.Mvc;
using System.Web.Routing;

namespace DeliverDancingGoatMVC
{
    public class RouteConfig : CmsRoutingEngine
    {
        public static RouteConfig Instance => new RouteConfig();

        public void RegisterRoutes(RouteCollection routes)
        {
            MapAllRoutes(routes);
        }

        protected override void MapDefaultRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        protected override void MapIgnoreRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
        }

        protected override void MapStaticRoutes(RouteCollection routes)
        {
            //// Placeholder to add static Routes
        }

        protected override List<CmsSystemTypeRoute> GetSystemTypeRoutes()
        {
            var routes = new List<CmsSystemTypeRoute>
            {
                new CmsSystemTypeRoute() {Action = "Show", Controller = "Articles", SystemType = "article"},
                new CmsSystemTypeRoute() {Action = "Detail", Controller = "Product", SystemType = "brewer"},
                new CmsSystemTypeRoute() {Action = "Detail", Controller = "Product", SystemType = "coffee"}
            };
            return routes;
        }
    }
}