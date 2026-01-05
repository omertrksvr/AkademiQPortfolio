using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace AkademiqPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly PortfolioDbContext _portfolioDbContext;

        public TestimonialController(PortfolioDbContext portfolioDbContext)
        {
            _portfolioDbContext = portfolioDbContext;
        }

        public IActionResult Index()
        {
            var values = _portfolioDbContext.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            _portfolioDbContext.Testimonials.Add(testimonial);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = _portfolioDbContext.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _portfolioDbContext.Testimonials.Update(testimonial);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = _portfolioDbContext.Testimonials.Find(id);
            _portfolioDbContext.Testimonials.Remove(value);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}