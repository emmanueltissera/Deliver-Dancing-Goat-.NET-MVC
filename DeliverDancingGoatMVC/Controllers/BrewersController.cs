using DeliverDancingGoatMVC.Models;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using KenticoCloud.Deliver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DeliverDancingGoatMVC.Controllers
{
    public class BrewersController : AsyncController
    {
        public async Task<ActionResult> Filter(BrewerFilterViewModel model)
        {
            var filters = new List<IFilter> {
                new EqualsFilter("system.type", "brewer"),
                new Order("elements.product_name"),
                new ElementsFilter("image", "price", "product_status"),
                new DepthFilter(0)
            };

            var manufacturers = model.GetManufacturerFilters().ToArray();
            if (manufacturers.Any())
            {
                filters.Add(new InFilter("elements.manufacturer", manufacturers));
            }

            var collection = await DeliverClientFactory<BaseProductCollectionViewModel>.GetItemsAsync(filters);

            return PartialView("BrewersList", collection);
        }

        public async Task<ActionResult> Index()
        {
            var filters = new List<IFilter> {
                new EqualsFilter("system.type", "brewer"),
                new Order("elements.product_name"),
                new ElementsFilter("image", "price", "product_status"),
                new DepthFilter(0)
            };

            var collection = await DeliverClientFactory<BaseProductCollectionViewModel>.GetItemsAsync(filters);

            return View(collection);
        }
    }
}