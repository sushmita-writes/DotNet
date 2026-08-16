using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("my-introduction")]
        public IActionResult About()
        {
            return View();
        }

        [Route("few-of-my-ongoing-or-completed-projects")]
        public IActionResult Projects()
        {
            return View();
        }
    }
}
