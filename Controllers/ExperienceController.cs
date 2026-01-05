using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace AkademiqPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly PortfolioDbContext _portfolioDbContext;

        public ExperienceController(PortfolioDbContext portfolioDbContext)
        {
            _portfolioDbContext = portfolioDbContext;
        }

        // 1. Listeleme: Veri tabanındaki tüm deneyimleri getirir
        public IActionResult Index()
        {
            var values = _portfolioDbContext.Experiences.ToList();
            return View(values);
        }

        // 2. Yeni Ekleme (Sayfayı Açar)
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        // 3. Yeni Ekleme (Veriyi Kaydeder)
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            _portfolioDbContext.Experiences.Add(experience);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        // 4. Güncelleme (Mevcut Veriyi Getirir)
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = _portfolioDbContext.Experiences.Find(id);
            return View(value);
        }

        // 5. Güncelleme (Değişiklikleri Kaydeder)
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            _portfolioDbContext.Experiences.Update(experience);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        // 6. Silme İşlemi
        public IActionResult DeleteExperience(int id)
        {
            var value = _portfolioDbContext.Experiences.Find(id);
            _portfolioDbContext.Experiences.Remove(value);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}