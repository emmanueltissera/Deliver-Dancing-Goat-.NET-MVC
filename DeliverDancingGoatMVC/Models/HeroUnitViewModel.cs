using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System.Linq;
using System.Web;

namespace DeliverDancingGoatMVC.Models
{
    public class HeroUnitViewModel : BaseContentItemViewModel
    {
        public const string ItemCodeName = "hero_unit";

        public Asset Image { get; set; }
        public HtmlString MarketingMessage { get; set; }
        public string Title { get; set; }

        protected override void MapContentForType(ContentItem content)
        {
            Image = content.GetAssets("image").FirstOrDefault();
            MarketingMessage = new HtmlString(content.GetString("marketing_message"));
            Title = content.GetString("title");
        }
    }
}