using AlloyTraining.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace AlloyTraining.Controllers
{
    public class NewsLandingPageController(IContentLoader loader) : PageControllerBase<NewsLandingPage>(loader)
    {
        public IActionResult Index(NewsLandingPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}
