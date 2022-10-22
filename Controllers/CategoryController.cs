using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace FPTBook.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext context;

        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Request()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Request(Request request)
        {
            TempData["Message"] = "Submitted successfully. Request is waiting for approval";
            context.requests.Add(request);
            context.SaveChanges();
            return View();
        }
    }
}
