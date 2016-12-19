using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Factories;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System.Collections.Generic;

namespace DeliverDancingGoatMVC.Helpers
{
    public static class PartialViewHelper
    {
        public static NavigationViewModel GetTopNavigation()
        {
            var filters = new List<IFilter> {
                new EqualsFilter("system.type", "navigation")
            };

            return DeliverClientFactory<NavigationViewModel>.GetItems(filters);
        }
    }
}