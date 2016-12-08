using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DeliverDancingGoatMVC.Models;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using KenticoCloud.Deliver;

namespace DeliverDancingGoatMVC.Controllers
{
    [RoutePrefix("articles")]
    public class ArticlesController : AsyncController
    {

        [Route]
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

        [Route("{id}")]
        public async Task<ActionResult> Show(string id)
        {
            try
            {
                var response = await DeliverClientFactory<ArticleViewModel>.GetItemByIdAsync(id);
                return View(response);
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