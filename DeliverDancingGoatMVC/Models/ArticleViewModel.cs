using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers;
using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeliverDancingGoatMVC.Models
{
    public class ArticleViewModel : BaseContentItemViewModel
    {
        public const string ItemCodeName = "article";

        public ArticleViewModel()
        {
            MaxDepth = 1;
        }

        public HtmlString BodyCopy { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public Dictionary<string, string> Personas { get; set; }
        public DateTime PostDate { get; set; }
        public List<ArticleViewModel> RelatedArticles { get; set; }
        public string Summary { get; set; }
        public Asset TeaserImage { get; set; }
        public string Title { get; set; }

        protected override void MapContentForType(ContentItem content, int currentDepth)
        {
            BodyCopy = new HtmlString(content.GetStringOrDefault("body_copy"));
            MetaDescription = content.GetStringOrDefault("meta_description");
            MetaKeywords = content.GetStringOrDefault("meta_keywords");
            Personas = content.GetTaxonomyItems("personas");
            PostDate = content.GetDateTimeOrDefault("post_date");
            RelatedArticles = content.GetModularContentOrDefault("related_articles").GetListOfModularContent<ArticleViewModel>(currentDepth + 1);
            Summary = content.GetString("summary");
            TeaserImage = content.GetAssets("teaser_image").FirstOrDefault();
            Title = content.GetStringOrDefault("title");
        }
    }
}