using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace AkademiqPortfolio.Controllers
{
    public class EducationController : Controller
    {
        private readonly PortfolioDbContext _portfolioDbContext;

        public EducationController(PortfolioDbContext portfolioDbContext)
        {
            _portfolioDbContext = portfolioDbContext;
        }

        // Listeleme Sayfası
        public IActionResult Index()
        {
            var values = _portfolioDbContext.Educations.ToList();
            return View(values);
        }

        // Yeni Eğitim Ekleme (Sayfa)
        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }

        // Yeni Eğitim Ekleme (İşlem)
        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            _portfolioDbContext.Educations.Add(education);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        // Güncelleme Sayfası (Verileri Getirir)
        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var value = _portfolioDbContext.Educations.Find(id);
            return View(value);
        }

        // Güncelleme İşlemi (Değişiklikleri Kaydeder)
        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            _portfolioDbContext.Educations.Update(education);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        // Silme İşlemi
        public IActionResult DeleteEducation(int id)
        {
            var value = _portfolioDbContext.Educations.Find(id);
            _portfolioDbContext.Educations.Remove(value);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}