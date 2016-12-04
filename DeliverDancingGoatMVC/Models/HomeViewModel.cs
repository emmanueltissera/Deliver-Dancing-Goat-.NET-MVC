using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;

namespace DeliverDancingGoatMVC.Models
{
    public class HomeViewModel : BaseContentItemViewModel
    {
        public const string ItemCodeName = "home";
        public HtmlString Contact { get; set; }
        public HeroUnitViewModel HeroUnit { get; set; }

        protected override void MapContentForType(ContentItem content)
        {
            Contact = new HtmlString(content.GetString("contact"));
            HeroUnit = content.GetModularContent("hero_unit").GetListOfModularContent<HeroUnitViewModel>().FirstOrDefault();
        }
    }
}