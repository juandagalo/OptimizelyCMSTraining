using AlloyTraining.Models.Pages;

namespace AlloyTraining.Models.ViewModels
{
    public class PageViewModel<T>(T currentPage) : IPageViewModel<T> where T : SitePageData
    {
        public T CurrentPage { get; set; } = currentPage;
        public StartPage StartPage { get; set; }
        public IEnumerable<SitePageData> MenuPages { get; set; }
        public IContent Section { get; set; }
    }
    public static class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T currentPage) where T : SitePageData
        {
            return new PageViewModel<T>(currentPage);
        }
    }
}
