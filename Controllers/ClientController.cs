using Microsoft.AspNetCore.Mvc;

namespace FPTBook.Controllers
{
    public class ClientController : Controller
    {

      
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

    }
}
