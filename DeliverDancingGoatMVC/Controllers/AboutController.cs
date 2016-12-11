using DeliverDancingGoatMVC.Models;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DeliverDancingGoatMVC.Controllers
{
    public class AboutController : AsyncController
    {
        public async Task<ActionResult> Index()
        {
            var model = await DeliverClientFactory<AboutUsViewModel>.GetItemAsync(AboutUsViewModel.ItemCodeName);
            return View(model);
        }
    }
}