using DeliverDancingGoatMVC.Models;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using KenticoCloud.Deliver;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DeliverDancingGoatMVC.Controllers
{
    public class ProductController : AsyncController
    {
        public async Task<ActionResult> Detail(string id)
        {
            try
            {
                var model = await DeliverClientFactory<GenericProductViewModel>.GetItemByIdAsync(id);
                return View(model.Item);
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