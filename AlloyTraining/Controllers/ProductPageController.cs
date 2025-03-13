using AlloyTraining.Models.Pages;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AlloyTraining.Controllers;

[TemplateDescriptor(Inherited = true)]
public class ProductPageController(IContentLoader loader) : PageControllerBase<ProductPage>(loader)
{
    public ActionResult Index(ProductPage currentPage)
    {
        return View(CreatePageViewModel(currentPage));
    }
}
