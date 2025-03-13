using AlloyTraining.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace AlloyTraining.Controllers
{
    public class StandardPageController(IContentLoader loader) : PageControllerBase<StandardPage>(loader)
    {
        public IActionResult Index(StandardPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}