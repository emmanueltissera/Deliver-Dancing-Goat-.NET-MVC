using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System.Collections.Generic;
using System.Linq;

namespace DeliverDancingGoatMVC.Models
{
    public class NavigationViewModel : BaseContentItemViewModel
    {
        public const string ItemCodeName = "navigation";

        public NavigationViewModel()
        {
            MaxDepth = 1;
        }

        public List<NavigationItemViewModel> TopNavigationItems { get; set; }

        protected override void MapContentForType(ContentItem content, int currentDepth)
        {
        }

        protected override void MapContentListForType(List<ContentItem> contentList, int currentDepth)
        {
            var navigationModel = contentList.FirstOrDefault();
            if (navigationModel != null)
            {
                TopNavigationItems = navigationModel.GetModularContent("top_navigation_items").GetListOfModularContent<NavigationItemViewModel>(currentDepth + 1);
            }
        }
    }
}