using Microsoft.AspNetCore.Mvc;

namespace ASPA008_1.Controllers
{
    public class CelebritiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
