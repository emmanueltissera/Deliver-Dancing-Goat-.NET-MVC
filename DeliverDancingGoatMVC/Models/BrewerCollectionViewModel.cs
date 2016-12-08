using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System.Collections.Generic;

namespace DeliverDancingGoatMVC.Models
{
    public class BaseProductCollectionViewModel : BaseContentItemViewModel
    {
        public List<BaseProductViewModel> Items { get; set; }

        protected override void MapContentListForType(List<ContentItem> contentList, int currentDepth)
        {
            Items = contentList.GetListOfModularContent<BaseProductViewModel>();
        }
    }
}