using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using System.Linq;

namespace AkademiqPortfolio.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        private readonly PortfolioDbContext _context;

        public _NavbarComponentPartial(PortfolioDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            // Sosyal medya hesaplarını listeliyoruz
            var values = _context.SocialMedia.ToList();
            return View(values);
        }
    }
}