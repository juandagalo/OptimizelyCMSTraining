using AlloyTraining.Models.Pages;
using EPiServer.Framework.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace AlloyTraining.Controllers;

[TemplateDescriptor(Inherited = true, AvailableWithoutTag = false,
Tags = new[] { EPiServer.Framework.Web.RenderingTags.Mobile })]
public class StartPageMobileController(IContentLoader loader) : PageControllerBase<StartPage>(loader)
{
    public IActionResult Index(StartPage currentPage)
    {
        return View(CreatePageViewModel(currentPage));
    }
}