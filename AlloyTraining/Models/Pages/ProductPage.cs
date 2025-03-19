using AlloyTraining.Business.EditorDescriptors;
using AlloyTraining.Business.SelectionFactories;
using EPiServer.Shell.ObjectEditing;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(
        GUID = "{B8E848F6-CFF7-45CC-9460-B5209ACBBED8}",
        DisplayName = "Product",
        Description = "Use this for software products that Alloy sells.",
        GroupName = SiteGroupNames.Specialized)]
    [SiteCommerceIcon]
    public class ProductPage : StandardPage//, IDisableOnPageEditView
    {
        public override void SetDefaultValues(ContentType contentType)
        {
            Theme = "theme1";
            base.SetDefaultValues(contentType);
        }

        [Display(
            Name = "Theme",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [SelectOne(SelectionFactoryType = typeof(ThemeSelectionFactory))]
        public virtual string Theme { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Unique selling points",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [Required]
        public virtual IList<string> UniqueSellingPoints { get; set; }

        [Display(
            Name = "Main content area",
            Description = "Drag and drop blocks and pages with partial templates.",
            GroupName = SystemTabNames.Content,
            Order = 330)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(
            Name = "Related content area",
            Description = "Drag and drop blocks and pages with partial templates.",
            GroupName = SystemTabNames.Content,
            Order = 340)]
        public virtual ContentArea RelatedContentArea { get; set; }
    }
}
