using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(
        DisplayName = "Editorial",
        GUID = "{DA2CBF63-E013-4B44-870A-042877DD2528}",
        Description = "\"Use this for a rich editorial text that will be reused in multiple places.",
        GroupName = SiteGroupNames.Common)]
    [SiteBlockIcon]
    public class EditorialBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Main body", 
            Description = "The main body will be shown in the main content area of the page, using theXHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }
    }
}
