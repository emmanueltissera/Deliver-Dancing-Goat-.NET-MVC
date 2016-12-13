using DeliverDancingGoatMVC.Models;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using KenticoCloud.Deliver;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DeliverDancingGoatMVC.Controllers
{
    public class ContactsController : AsyncController
    {
        [ChildActionOnly]
        public ActionResult CompanyAddress()
        {
            //// Filter removed since the HomeViewModel is anyhow cached and reused.
            var contact = DeliverClientFactory<HomeViewModel>.GetItem(HomeViewModel.ItemCodeName).Contact;
            return Content(contact.ToHtmlString());
        }

        public async Task<ActionResult> Index()
        {
            var filters = new List<IFilter> {
                new EqualsFilter("system.type", "cafe"),
                new EqualsFilter("elements.country", "USA")
            };

            var model = await DeliverClientFactory<ContactsViewModel>.GetItemsAsync(filters);
            return View(model);
        }
    }
}