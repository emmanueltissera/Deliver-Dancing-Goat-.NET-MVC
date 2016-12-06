using EmmTi.KenticoCloudConsumer.EnhancedDeliver.Models;
using KenticoCloud.Deliver;
using System.Linq;

namespace DeliverDancingGoatMVC.Models
{
    public class CafeViewModel : BaseContentItemViewModel
    {
        public const string ItemCodeName = "cafe";

        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Asset Photo { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        protected override void MapContentForType(ContentItem content)
        {
            City = content.GetString("city");
            Country = content.GetString("country");
            Email = content.GetString("email");
            Phone = content.GetString("phone");
            Photo = content.GetAssets("photo").FirstOrDefault();
            State = content.GetString("state");
            Street = content.GetString("street");
            ZipCode = content.GetString("zip_code");
        }
    }
}