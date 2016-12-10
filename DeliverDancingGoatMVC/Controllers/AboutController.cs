using DeliverDancingGoatMVC.Models;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DeliverDancingGoatMVC.Controllers
{
    [RoutePrefix("about")]
    public class AboutController : AsyncController
    {
        [Route]
        public async Task<ActionResult> Index()
        {
            var model = await DeliverClientFactory<AboutUsViewModel>.GetItemAsync(AboutUsViewModel.ItemCodeName);
            return View(model);
        }
    }
}