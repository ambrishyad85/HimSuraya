using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HimSuraya.Controllers
{
    public class HomeController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }
    }
}
