using AlloyTraining.Models.Blocks;
using AlloyTraining.Models.ViewModels;
using EPiServer.Filters;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AlloyTraining.Components
{
    public class ListingBlockComponent(IContentLoader loader) : BlockComponent<ListingBlock>
    {
        private readonly IContentLoader loader = loader;

        protected override IViewComponentResult InvokeComponent(ListingBlock currentBlock)
        {
            ListingBlockViewModel viewmodel = new()
            {
                Heading = currentBlock.Heading
            };

            if (currentBlock.ShowChildrenOfThisPage != null)
            {
                IEnumerable<PageData> children = loader.GetChildren<PageData>(currentBlock.ShowChildrenOfThisPage);

                // Remove pages:
                // 1. that are not published
                // 2. that the visitor does not have Read access to
                // 3. that do not have a page template
                IEnumerable<IContent> filteredChildren = FilterForVisitor.Filter(children);

                // 4. that do not have "Display in navigation" selected
                viewmodel.Pages = filteredChildren.Cast<PageData>().Where(page => page.VisibleInMenu);
            }
            return View(viewmodel);
        }
    }
}
