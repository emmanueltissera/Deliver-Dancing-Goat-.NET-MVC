using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System.Collections.Generic;
using System.Linq;

namespace DeliverDancingGoatMVC.Models
{
    public class CafeCollectionViewModel : BaseContentItemViewModel
    {
        public List<CafeViewModel> CompanyCafes { get; set; }

        public List<CafeViewModel> PartnerCafes { get; set; }

        protected override void MapContentListForType(List<ContentItem> contentList, int currentDepth)
        {
            CompanyCafes = contentList.Where(c => c.GetString("country") == "USA").GetListOfModularContent<CafeViewModel>();
            PartnerCafes = contentList.Where(c => c.GetString("country") != "USA").GetListOfModularContent<CafeViewModel>();
        }
    }
}