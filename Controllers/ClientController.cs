using FPTBook.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FPTBook.Controllers
{

    public class ClientController : Controller
    {
        public readonly ApplicationDbContext context;

        public ClientController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [Route("/")]

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

        public IActionResult Store()
        {
            return View(context.Books.ToList());
        }

        public IActionResult Detail(int id)
        {
            var cate = context.Categories.ToList();
            var books = context.Books.Find(id);
            return View(books);
        }

    }
}
