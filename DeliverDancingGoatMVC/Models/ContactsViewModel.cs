using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System.Collections.Generic;
using System.Linq;

namespace DeliverDancingGoatMVC.Models
{
    public class ContactsViewModel : BaseContentItemViewModel
    {
        public List<CafeViewModel> Cafes { get; set; }
        public CafeViewModel Roastery { get; set; }

        protected override void MapContentListForType(List<ContentItem> contentList, int currentDepth)
        {
            Cafes = contentList.GetListOfModularContent<CafeViewModel>();
            Roastery = Cafes.FirstOrDefault();
        }
    }
}