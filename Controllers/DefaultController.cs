using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace AkademiqPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        private readonly PortfolioDbContext _context;
        public DefaultController(PortfolioDbContext context) => _context = context;

        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            // Mesaj tarihini otomatik atayalım
            message.SendDate = DateTime.Now;
            message.IsRead = false;

            _context.Messages.Add(message);
            _context.SaveChanges();

            // Mesaj gönderildikten sonra sayfayı yeniler
            return RedirectToAction("Index");
        }
    }
}