﻿using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "Listing Block",
        GUID = "{C754429A-9DA4-4FAB-99A3-17CB45396C33}",
        GroupName = SiteGroupNames.Common,
        Description = "Choose a page in the tree, and its children will be listed, with a heading.")]
    public class ListingBlock : BlockData 
    {
        [Display(Name = "Heading", Order = 10)]
        public virtual string Heading { get; set; }

        [Display(Name = "Show children of this page", Order = 20)]
        public virtual PageReference ShowChildrenOfThisPage { get; set; }
    }
}
