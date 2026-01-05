using Microsoft.AspNetCore.Mvc;

namespace AkademiqPortfolio.ViewComponents
{
    // Sınıf isminin sonuna 'ViewComponent' eklemeyi unutma, yoksa 'bulunamadı' hatası alırsın.
    public class _ContactComponentPartialViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}