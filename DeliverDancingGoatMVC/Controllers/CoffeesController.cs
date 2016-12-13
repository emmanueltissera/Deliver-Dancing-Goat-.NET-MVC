using DeliverDancingGoatMVC.Models;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using KenticoCloud.Deliver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DeliverDancingGoatMVC.Controllers
{
    public class CoffeesController : AsyncController
    {
        public async Task<ActionResult> Filter(CoffeesFilterViewModel model)
        {
            var filters = new List<IFilter> {
                new EqualsFilter("system.type", "coffee"),
                new Order("elements.product_name"),
                new ElementsFilter("image", "price", "product_status", "processing"),
                new DepthFilter(0),
            };

            var filter = model.GetFilteredValues().ToArray();
            if (filter.Any())
            {
                filters.Add(new InFilter("elements.processing", filter));
            }

            var collection = await DeliverClientFactory<BaseProductCollectionViewModel>.GetItemsAsync(filters);
            return PartialView("CoffeeList", collection);
        }

        public async Task<ActionResult> Index()
        {
            var filters = new List<IFilter> {
                new EqualsFilter("system.type", "coffee"),
                new Order("elements.product_name"),
                new ElementsFilter("image", "price", "product_status", "processing"),
                new DepthFilter(0)
            };

            var collection = await DeliverClientFactory<BaseProductCollectionViewModel>.GetItemsAsync(filters);
            return View(collection);
        }
    }
}