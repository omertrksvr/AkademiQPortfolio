using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace AkademiqPortfolio.ViewComponents
{
    public class _ProjectComponentPartial : ViewComponent
    {
        private readonly PortfolioDbContext _context;
        public _ProjectComponentPartial(PortfolioDbContext context) => _context = context;

        public IViewComponentResult Invoke()
        {
            var values = _context.Projects.ToList(); // Tablo ismini kontrol et (ProjectTables veya Projects)
            return View(values);
        }
    }
}