using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

namespace FPTBook.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext context;

        public AdminController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Route("/")]
        public IActionResult Index()
        {
            var requests = context.Requests.ToList();
            return View(requests);
        }

     
        public IActionResult ApproveRequest(int id)
        {
            var request = new Category();
             request.Name = context.Requests.Where(x=> x.Id == id).First().Name;
             request.Description = context.Requests.Where(x=> x.Id == id).First().Description;
            TempData["Message"] = "New Category has been added";
            var category = context.Categories.Add(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult RejectRequest(int? id)
        {
            if(id == null) return NotFound();
            else
            {
                TempData["Message"] = "Request has been rejected.";
                var request = context.Requests.Find(id);
                context.Requests.Remove(request);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult BookOwner()
        {
            // var customer = context.AspNetUsers.ToList();
            return View();
        }
    }
}
