using DeliverDancingGoatMVC.Helpers;
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
                    Item = content.GetContent<CoffeeViewModel>();
                    break;

                case BrewerViewModel.ItemCodeName:
                    Item = content.GetContent<BrewerViewModel>();
                    break;
            }
        }
    }
}