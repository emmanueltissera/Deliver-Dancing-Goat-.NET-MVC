using DeliverDancingGoatMVC.Models;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DeliverDancingGoatMVC.Controllers
{
    public class HomeController : AsyncController
    {
        public async Task<ActionResult> Index()
        {
            var model = await DeliverClientFactory<HomeViewModel>.GetItemAsync(HomeViewModel.ItemCodeName);
            return View(model);
        }
    }
}