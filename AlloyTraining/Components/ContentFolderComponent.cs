using AlloyTraining.Models.ViewModels;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AlloyTraining.Components
{
    public class ContentFolderComponent(IContentLoader loader) : PartialContentComponent<ContentFolder>
    {
        protected readonly IContentLoader loader = loader;

        protected override IViewComponentResult InvokeComponent(ContentFolder currentContent)
        {
            ContentFolderViewModel viewmodel = new()
            {
                CurrentFolder = currentContent,
                ItemsCount = loader.GetChildren<IContent>(currentContent.ContentLink).Count()
            };
            return View(viewmodel);
        }
    }
}
