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
        public HtmlString BodyCopy { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public List<KeyValuePair<string, string>> Personas { get; set; }
        public DateTime PostDate { get; set; }
        public List<ArticleViewModel> RelatedArticles { get; set; }
        public string Summary { get; set; }
        public Asset TeaserImage { get; set; }
        public string Title { get; set; }

        private static List<KeyValuePair<string, string>> GetTaxonomyList(ContentItem content, string elementCode)
        {
            var element = content.Elements[elementCode];
            var taxonomyList = new List<KeyValuePair<string, string>>();

            if (element == null || element.value == null)
            {
                return taxonomyList;
            }

            foreach (var item in element.value)
            {
                taxonomyList.Add(new KeyValuePair<string, string>(item.codename.ToString(), item.name.ToString()));
            }

            return taxonomyList;
        }

        protected override void MapContentForType(ContentItem content)
        {
            try
            {
                BodyCopy = new HtmlString(content.GetString("body_copy"));
                MetaDescription = content.GetString("meta_description");
                MetaKeywords = content.GetString("meta_keywords");
                Personas = GetTaxonomyList(content, "personas");
                PostDate = content.GetDateTime("post_date");
                //RelatedArticles = content.GetModularContent("related_articles").GetListOfModularContent<ArticleViewModel>();
                Summary = content.GetString("summary");
                TeaserImage = content.GetAssets("teaser_image").FirstOrDefault();
                Title = content.GetString("title");
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }
    }
}