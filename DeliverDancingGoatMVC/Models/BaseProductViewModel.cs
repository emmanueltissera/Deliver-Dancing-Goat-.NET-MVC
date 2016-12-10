using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers;

namespace DeliverDancingGoatMVC.Models
{
    public class BaseProductViewModel : BaseContentItemViewModel
    {       
        public Asset Image { get; set; }
        public HtmlString LongDescription { get; set; }
        public double Price { get; set; }
        public string ProductName { get; set; }
        public KeyValuePair<string, string> ProductStatus { get; set; }
        public HtmlString ShortDescription { get; set; }

        protected override void MapContentForType(ContentItem content, int currentDepth)
        {
            Image = content.GetAssets("image").FirstOrDefault();
            LongDescription = new HtmlString(content.GetStringOrDefault("long_description"));
            Price = content.GetNumber("price");
            ProductName = content.GetStringOrDefault("product_name");
            ProductStatus = content.GetSelectedTaxonomy("product_status");
            ShortDescription = new HtmlString(content.GetStringOrDefault("short_description"));
        }
    }
}