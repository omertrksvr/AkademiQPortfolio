using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace AkademiqPortfolio.Controllers
{
    public class SkillController : Controller
    {
        private readonly PortfolioDbContext _portfolioDbContext;
        public SkillController(PortfolioDbContext portfolioDbContext)
        {
            _portfolioDbContext = portfolioDbContext;
        }

        public IActionResult Index()
        {

            var SkillList = _portfolioDbContext.SkillTables.ToList();
            return View(SkillList);
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var SkillUpdate = _portfolioDbContext.SkillTables.Find(id);

            return View(SkillUpdate);
        }

        [HttpPost] 
        public IActionResult UpdateSkill(SkillTable skill)
        {

            _portfolioDbContext.SkillTables.Update(skill); 
            _portfolioDbContext.SaveChanges(); 


            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {

            var value = _portfolioDbContext.SkillTables.Find(id); 

            _portfolioDbContext.SkillTables.Remove(value); 

            _portfolioDbContext.SaveChanges(); 

            return RedirectToAction("Index"); 
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(SkillTable table)
        {
            _portfolioDbContext.SkillTables.Add(table);
            _portfolioDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}