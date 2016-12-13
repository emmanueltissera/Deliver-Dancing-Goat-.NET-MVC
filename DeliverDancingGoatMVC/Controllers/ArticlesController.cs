using DeliverDancingGoatMVC.Models;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using KenticoCloud.Deliver;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DeliverDancingGoatMVC.Controllers
{
    public class ArticlesController : AsyncController
    {
        public async Task<ActionResult> Index()
        {
            var filters = new List<IFilter> {
                new EqualsFilter("system.type", "article"),
                new Order("elements.post_date", OrderDirection.Descending),
                new ElementsFilter("teaser_image", "post_date", "summary")
            };

            var collection = await DeliverClientFactory<ArticleCollectionViewModel>.GetItemsAsync(filters);

            return View(collection);
        }

        public async Task<ActionResult> Show(string id)
        {
            try
            {
                var model = await DeliverClientFactory<ArticleViewModel>.GetItemByIdAsync(id);
                return View(model);
            }
            catch (DeliverException ex)
            {
                if (ex.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new HttpException(404, "Not found");
                }
                else
                {
                    throw;
                }
            }
        }
    }
}