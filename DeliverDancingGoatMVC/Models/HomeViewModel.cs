using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeliverDancingGoatMVC.Models
{
    public class HomeViewModel : BaseContentItemViewModel
    {
        public const string ItemCodeName = "home";
        public List<ArticleViewModel> Articles { get; set; }
        public List<CafeViewModel> Cafes { get; set; }
        public HtmlString Contact { get; set; }
        public HeroUnitViewModel HeroUnit { get; set; }
        public FactViewModel OurStory { get; set; }

        protected override void MapContentForType(ContentItem content, int currentDepth)
        {
            Articles = content.GetModularContent("articles").GetListOfModularContent<ArticleViewModel>();
            Cafes = content.GetModularContent("cafes").GetListOfModularContent<CafeViewModel>();
            Contact = new HtmlString(content.GetString("contact"));
            HeroUnit = content.GetModularContent("hero_unit").GetListOfModularContent<HeroUnitViewModel>().FirstOrDefault();
            OurStory = content.GetModularContent("our_story").GetListOfModularContent<FactViewModel>().FirstOrDefault();
        }
    }
}