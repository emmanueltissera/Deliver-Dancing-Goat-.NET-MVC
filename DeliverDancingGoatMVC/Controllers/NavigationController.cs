using System.Collections.Generic;
using DeliverDancingGoatMVC.Models;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using System.Web.Mvc;
using KenticoCloud.Deliver;

namespace DeliverDancingGoatMVC.Controllers
{
    public class NavigationController : AsyncController
    {
        [ChildActionOnly]
        public ActionResult TopNavigation()
        {
            var filters = new List<IFilter> {
                new EqualsFilter("system.type", "navigation")
            };

            //// Filter removed since the HomeViewModel is anyhow cached and reused.
            var model = DeliverClientFactory<NavigationViewModel>.GetItems(filters);
            return View(model);
        }
    }
}