using AlloyTraining.Models.Pages; // SitePageData
using AlloyTraining.Models.ViewModels; // PreviewPageViewModel
using EPiServer.Framework.DataAnnotations; // [TemplateDescriptor]
using EPiServer.Framework.Web; // TemplateTypeCategories, RenderingTags
using EPiServer.Web; // IRenderTemplate<T>
using EPiServer.Web.Mvc; // ActionControllerBase
using Microsoft.AspNetCore.Mvc; // IActionResult

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview, RenderingTags.Edit },
        AvailableWithoutTag = false)]
    public class PreviewPageController(IContentLoader loader) : ActionControllerBase, IRenderTemplate<BlockData>
    {
        protected readonly IContentLoader loader = loader;

        public IActionResult Index(IContent currentContent)
        {
            SitePageData startPage = loader.Get<SitePageData>(ContentReference.StartPage);
            PreviewPageViewModel viewmodel = new(startPage, currentContent);
            return View(viewmodel);
        }
    }
}