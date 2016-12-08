using DeliverDancingGoatMVC.Helpers;
using KenticoCloud.Deliver;

namespace DeliverDancingGoatMVC.Models
{
    public class CoffeeViewModel : BaseProductViewModel
    {
        public const string ItemCodeName = "coffee";
        public string Altitude { get; set; }
        public string Country { get; set; }
        public string Farm { get; set; }
        public string Processing { get; set; }
        public string Variety { get; set; }

        protected override void MapContentForType(ContentItem content, int currentDepth)
        {
            base.MapContentForType(content, currentDepth + 1);
            Altitude = content.GetStringOrDefault("altitude");
            Country = content.GetStringOrDefault("country");
            Farm = content.GetStringOrDefault("farm");
            Processing = content.GetStringOrDefault("processing");
            Variety = content.GetStringOrDefault("variety");
        }
    }
}