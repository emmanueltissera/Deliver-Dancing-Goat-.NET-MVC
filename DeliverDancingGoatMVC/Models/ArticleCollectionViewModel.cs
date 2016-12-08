using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System.Collections.Generic;

namespace DeliverDancingGoatMVC.Models
{
    public class ArticleCollectionViewModel : BaseContentItemViewModel
    {
        public List<ArticleViewModel> Items { get; set; }

        protected override void MapContentListForType(List<ContentItem> contentList, int currentDepth)
        {
            Items = contentList.GetListOfModularContent<ArticleViewModel>();
        }
    }
}