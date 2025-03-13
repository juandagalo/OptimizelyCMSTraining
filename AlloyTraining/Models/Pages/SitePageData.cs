using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [CultureSpecific]
        [Display(Name = "Meta Title",
            GroupName = SiteTabNames.SEO, Order = 10)]
        [StringLength(60, MinimumLength = 5)]
        public virtual string MetaTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta Keywords",
            GroupName = SiteTabNames.SEO, Order = 20)]
        public virtual string MetaKeywords { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta Description",
            GroupName = SiteTabNames.SEO, Order = 30)]
        [UIHint(UIHint.Textarea)]
        public virtual string MetaDescription { get; set; }

        [Display(Name = "Page Image",
            GroupName = SystemTabNames.Content, Order = 40)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference PageImage { get; set; }
    }
}