using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace AkademiqPortfolio.Controllers
{
    public class AboutController : Controller
    {
        private readonly PortfolioDbContext _portfolioDbContext;

        public AboutController(PortfolioDbContext portfolioDbContext)
        {
            _portfolioDbContext = portfolioDbContext;
        }

        // Listeleme (Hakkımda bilgisini getirir)
        public IActionResult Index()
        {
            var values = _portfolioDbContext.Abouts.ToList();
            return View(values);
        }

        // Yeni Kayıt Ekleme (Başlangıçta bir kez gerekebilir)
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            _portfolioDbContext.Abouts.Add(about);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        // Güncelleme Sayfası
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = _portfolioDbContext.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            _portfolioDbContext.Abouts.Update(about);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}