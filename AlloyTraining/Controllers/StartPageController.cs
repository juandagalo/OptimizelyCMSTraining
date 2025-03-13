using AlloyTraining.Models.Pages;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AlloyTraining.Controllers;

[TemplateDescriptor(Inherited = true)]
public class StartPageController(IContentLoader loader) : PageControllerBase<StartPage>(loader)
{
    public IActionResult Index(StartPage currentPage)
    {
        return View(CreatePageViewModel(currentPage));
    }
}
