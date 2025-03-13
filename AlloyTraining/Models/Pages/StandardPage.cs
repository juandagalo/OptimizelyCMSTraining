using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(
        DisplayName = "Standard",
        GUID = "{BF36CA8B-2F3E-493D-933D-B582A4931E40}",
        Description = "Use this page type unless you need a more specialized one.",
        GroupName = SiteGroupNames.Common,
        Order = 10)]
    [SitePageIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) }, Exclude = new[] {typeof(ProductPage)})]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }
    }
}
