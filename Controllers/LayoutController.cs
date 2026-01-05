using Microsoft.AspNetCore.Mvc;

namespace AkademiqPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
