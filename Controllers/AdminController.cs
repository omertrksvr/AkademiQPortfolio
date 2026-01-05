using Microsoft.AspNetCore.Mvc;

namespace AkademiqPortfolio.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
