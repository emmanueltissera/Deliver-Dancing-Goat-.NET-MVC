using DeliverDancingGoatMVC.Models;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using KenticoCloud.Deliver;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DeliverDancingGoatMVC.Controllers
{
    public class CafesController : AsyncController
    {
        public async Task<ActionResult> Index()
        {
            var filters = new List<IFilter> {
                new EqualsFilter("system.type", "cafe"),
                new Order("system.name")
            };

            var collection = await DeliverClientFactory<CafeCollectionViewModel>.GetItemsAsync(filters);
            return View(collection);
        }
    }
}