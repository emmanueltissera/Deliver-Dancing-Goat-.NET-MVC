using DeliverDancingGoatMVC.Models;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DeliverDancingGoatMVC.Controllers
{
    public class HomeController : AsyncController
    {
        [Route]
        public async Task<ActionResult> Index()
        {
            var response = await DeliverClientFactory<HomeViewModel>.GetItemAsync(HomeViewModel.ItemCodeName);
            return View(response);
        }
    }
}