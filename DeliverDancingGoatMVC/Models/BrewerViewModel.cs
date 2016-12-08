using DeliverDancingGoatMVC.Helpers;
using KenticoCloud.Deliver;

namespace DeliverDancingGoatMVC.Models
{
    public class BrewerViewModel : BaseProductViewModel
    {
        public const string ItemCodeName = "brewer";
        public string Manufacturer { get; set; }

        protected override void MapContentForType(ContentItem content, int currentDepth)
        {
            base.MapContentForType(content, currentDepth + 1);
            Manufacturer = content.GetStringOrDefault("manufacturer");
        }
    }
}