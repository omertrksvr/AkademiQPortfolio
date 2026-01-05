using Microsoft.AspNetCore.Mvc;

namespace AkademiqPortfolio.ViewComponents.AdminLayoutComponents
{
    public class _AdminLayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
