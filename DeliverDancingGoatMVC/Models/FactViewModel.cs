using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System.Linq;
using System.Web;

namespace DeliverDancingGoatMVC.Models
{
    public class FactViewModel : BaseContentItemViewModel
    {
        public const string ItemCodeName = "fact_about_us";

        public HtmlString Description { get; set; }
        public Asset Image { get; set; }
        public string Title { get; set; }

        protected override void MapContentForType(ContentItem content, int currentDepth)
        {
            Description = new HtmlString(content.GetString("description"));
            Image = content.GetAssets("image").FirstOrDefault();
            Title = content.GetString("title");
        }
    }
}