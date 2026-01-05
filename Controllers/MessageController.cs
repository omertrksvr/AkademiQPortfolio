using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace AkademiqPortfolio.Controllers
{
    public class MessageController : Controller
    {
        private readonly PortfolioDbContext _portfolioDbContext;

        public MessageController(PortfolioDbContext portfolioDbContext)
        {
            _portfolioDbContext = portfolioDbContext;
        }

        // Mesaj Listesi (Gelen Kutusu)
        public IActionResult Index()
        {
            var values = _portfolioDbContext.Messages.ToList();
            return View(values);
        }

        // Mesaj Detayını Görüntüleme (Opsiyonel)
        public IActionResult MessageDetail(int id)
        {
            var value = _portfolioDbContext.Messages.Find(id);
            return View(value);
        }

        // Mesaj Silme
        public IActionResult DeleteMessage(int id)
        {
            var value = _portfolioDbContext.Messages.Find(id);
            _portfolioDbContext.Messages.Remove(value);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}