using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "Teaser",
        GroupName = SiteGroupNames.Common,
        GUID = "{0AE1A972-6B19-42E7-8108-525309B46740}",
        Description = "Use this for rich text with heading, image and page link that will be reused in multiple places.")]
    [SiteBlockIcon]
    public class TeaserBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Order = 10)]
        public virtual string TeaserHeading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Rich Text",
            Order = 20)]
        public virtual XhtmlString TeaserText { get; set; }

        [Display(
            Name = "Image",
            Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TeaserImage { get; set; }

        [Display(
            Name = "Link",
            Order = 40)]
        public virtual PageReference TeaserLink { get; set; }


    }
}
