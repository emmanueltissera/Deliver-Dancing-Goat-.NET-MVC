using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;

namespace DeliverDancingGoatMVC.Models
{
    public class GenericProductViewModel : BaseContentItemViewModel
    {
        public BaseProductViewModel Item { get; set; }

        protected override void MapContentForType(ContentItem content, int currentDepth)
        {
            switch (content.System.Type)
            {
                case CoffeeViewModel.ItemCodeName:
                    Item = content.MapContent<CoffeeViewModel>();
                    break;

                case BrewerViewModel.ItemCodeName:
                    Item = content.MapContent<BrewerViewModel>();
                    break;
            }
        }
    }
}