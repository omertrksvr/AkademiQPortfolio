using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using System.Linq;

namespace AkademiqPortfolio.ViewComponents
{
    public class _ExperienceComponentPartialViewComponent : ViewComponent
    {
        private readonly PortfolioDbContext _context;

        public _ExperienceComponentPartialViewComponent(PortfolioDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            // Deneyimleri başlangıç tarihine göre en yeniden en eskiye sıralıyoruz
            var values = _context.Experiences.OrderByDescending(x => x.StartDate).ToList();
            return View(values);
        }
    }
}