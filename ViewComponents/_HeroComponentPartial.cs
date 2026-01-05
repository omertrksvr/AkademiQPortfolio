using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using System.Linq;

namespace AkademiqPortfolio.ViewComponents
{
    public class _HeroComponentPartial : ViewComponent
    {
        private readonly PortfolioDbContext _context;

        public _HeroComponentPartial(PortfolioDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            // Hakkımda tablosundaki ilk (ve tek) veriyi alıyoruz
            var values = _context.Abouts.FirstOrDefault();
            return View(values);
        }
    }
}