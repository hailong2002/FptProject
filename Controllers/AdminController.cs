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

        [Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            var requests = context.Requests.ToList();
            return View(requests);
        }


        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
        public IActionResult Customer()
        {
            var role = context.UserRoles.Where(r =>r.RoleId == "C").First().UserId;
            var customer = context.Users.Where(c => c.Id == role).ToList();
            return View(customer);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult BookOwner()
        {
            /*var roles = context.UserRoles.Where(r => r.RoleId == "B").First().UserId.ToList();
            var role = "";
            for (int i = 0; i<= roles.Count(); i++)
            {
               role =  roles[i];
            }*/
           // var bookowner = context.Users.Where(b=>b.Id == role).ToList();
         //   return View(bookowner)
                return View();
        }
    }
}
