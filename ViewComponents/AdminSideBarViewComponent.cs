using Microsoft.AspNetCore.Mvc;

namespace AkademiqPortfolio.ViewComponents
{
    public class AdminSideBarViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
