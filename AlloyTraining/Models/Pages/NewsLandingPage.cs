using AlloyTraining.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "News Landing", GUID = "{F84F9B7E-C417-48BE-9C3F-F5903EAB97B1}",
        Description = "Use this as a landing page for a list of news articles.",
        GroupName = SiteGroupNames.News)]
    [SitePageIcon]
    public class NewsLandingPage : StandardPage
    {
        [Display(Name = "News list", Order = 315)]
        public virtual ListingBlock NewsListing { get; set; }
    }
}
