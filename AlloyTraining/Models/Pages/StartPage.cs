using AlloyTraining.Models.Media;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages;

[ContentType(
    DisplayName = "Start",
    GUID = "3D9C7B19-8F0C-4E7A-ACA6-9BB5C1A76E63",
    Description = "The home page for a website with an area for blocks and partial pages.",
    GroupName = SiteGroupNames.Specialized, Order = 10)]
[SiteStartIcon]
[AvailableContentTypes(Include = new[] {typeof(StandardPage)})]
public class StartPage : SitePageData
{
    [CultureSpecific]
    [Display(
        Name = "Heading",
        Description = "If the Heading is not set, the page falls back to showing the Name.",
        GroupName = SystemTabNames.Content,
        Order = 10)]
    public virtual string Heading { get; set; }

    [CultureSpecific]
    [Display(
        Name = "MainBody",
        Description = "The main body uses the XHTML-editor so you can insert, for\r\nexample text, images, and tables.",
        GroupName = SystemTabNames.Content,
        Order = 20)]
    public virtual XhtmlString MainBody { get; set; }

    [CultureSpecific]
    [Display(
        Name = "Main content area",
        Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
        GroupName = SystemTabNames.Content,
        Order = 30)]
    [AllowedTypes(typeof(StandardPage), typeof(BlockData), 
        typeof(ImageData), typeof(ContentFolder), typeof(PdfFile))]
    public virtual ContentArea MainContentArea { get; set; }

    [CultureSpecific]
    [Display(
        Name = "Footer text",
        Description = "The footer text is shown at the bottom of every page.",
        GroupName = SiteTabNames.SiteSettings,
        Order = 10)]
    public virtual string FooterText { get; set; }
}