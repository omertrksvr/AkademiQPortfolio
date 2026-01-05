using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace AkademiqPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly PortfolioDbContext _portfolioDbContext;

        public SocialMediaController(PortfolioDbContext portfolioDbContext)
        {
            _portfolioDbContext = portfolioDbContext;
        }

        public IActionResult Index()
        {
            var values = _portfolioDbContext.SocialMedia.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedium socialMedium)
        {
            _portfolioDbContext.SocialMedia.Add(socialMedium);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        // Diğer metodlarda (Update/Delete) SocialMedium tipini ve tablo ismini kullanmayı unutmayın
    }
}