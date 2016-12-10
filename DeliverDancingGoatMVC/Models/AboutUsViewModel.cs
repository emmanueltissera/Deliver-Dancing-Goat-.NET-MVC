using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System.Collections.Generic;

namespace DeliverDancingGoatMVC.Models
{
    public class AboutUsViewModel : BaseContentItemViewModel
    {
        public const string ItemCodeName = "about_us";
        public List<FactViewModel> Facts { get; set; }

        protected override void MapContentForType(ContentItem content, int currentDepth)
        {
            Facts = content.GetModularContent("facts").GetListOfModularContent<FactViewModel>(currentDepth + 1);
        }
    }
}