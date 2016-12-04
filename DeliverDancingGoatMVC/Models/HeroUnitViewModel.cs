using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;

namespace DeliverDancingGoatMVC.Models
{
    public class HeroUnitViewModel : BaseContentItemViewModel
    {
        public const string ItemCodeName = "hero_unit";

        public string Title { get; set; }
        public Asset Image { get; set; }
        public HtmlString MarketingMessage { get; set; }

        protected override void MapContentForType(ContentItem content)
        {
            Title = content.GetString("title");
            MarketingMessage = new HtmlString(content.GetString("marketing_message"));
            Image = content.GetAssets("image").FirstOrDefault();
        }
    }
}