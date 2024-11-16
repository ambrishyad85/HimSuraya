using Microsoft.AspNetCore.Mvc;

namespace HimSuraya.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
