using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace AkademiqPortfolio.ViewComponents
{
    // Sınıf isminin sonuna 'ViewComponent' ekledik
    public class _AboutComponentPartialViewComponent : ViewComponent
    {
        private readonly PortfolioDbContext _context;

        public _AboutComponentPartialViewComponent(PortfolioDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.FirstOrDefault();
            return View(values);
        }
    }
}