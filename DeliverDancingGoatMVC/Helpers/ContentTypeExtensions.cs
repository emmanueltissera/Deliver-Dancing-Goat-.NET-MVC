using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers;
using KenticoCloud.Deliver;
using System;
using System.Collections.Generic;

namespace DeliverDancingGoatMVC.Helpers
{
    /// <summary>
    /// Content Type Extensions to prevent exceptions when loading only certain fields
    /// </summary>
    /// <remarks>Will be moved to EmmTi.KenticoCloudConsumer.EnhancedDeliver.Helpers.ContentDeliveryHelper</remarks>
    public static class ContentTypeExtensions
    {
        public static DateTime GetDateTimeOrDefault(this ContentItem content, string element, DateTime defaultValue = default(DateTime))
        {
            return content.Elements[element] == null ? defaultValue : content.GetDateTime(element);
        }

        public static IEnumerable<ContentItem> GetModularContentOrDefault(this ContentItem content, string element)
        {
            return content.Elements[element] == null ? new List<ContentItem>() : content.GetModularContent(element);
        }

        public static KeyValuePair<string, string> GetSelectedTaxonomyOrDefault(this ContentItem content, string element)
        {
            return content.Elements[element] == null || content.Elements[element].value.Count == 0 ? new KeyValuePair<string, string>() : content.GetSelectedTaxonomy(element);
        }

        public static string GetStringOrDefault(this ContentItem content, string element, string defaultValue = "")
        {
            return content.Elements[element] == null ? defaultValue : content.GetString(element);
        }
    }
}