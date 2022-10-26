using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;

namespace FPTBook.Controllers
{
    public class OrderController : Controller
    {

        public ApplicationDbContext context { get; set; }

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Authorize (Roles = "Customer")]
        public IActionResult MakeOrder(int id, int quantity, string customerName)
        {
            var order = new Order();
            order.OrderQuantity = quantity;
            order.BookId = id;
            order.Customer = customerName;
            order.OrderName = context.Books.Find(id).Title;
            order.OrderPrice = (context.Books.Find(id).Price)*quantity;
            context.Orders.Add(order);
            context.SaveChanges();
            return View(order);
        }

        [Authorize(Roles = "BookOwner")]
        public IActionResult Record()
        {
            var customerOrder = context.Orders.ToList();
            return View(customerOrder);
        }

        [Authorize (Roles = "BookOwner")]
        public IActionResult Approve(int id, int quantity, int bookId)
        {
            TempData["approve"] = "Order has been approved";
            var order = context.Orders.Find(id);
            //get name of book order
            var name = context.Orders.Where(x=>x.Id == id).First().OrderName;
            //decrease quantity of book in db
            context.Books.Where(x => x.Title == name).First().Quantity -= quantity;
     
            context.Orders.Remove(order);
            context.SaveChanges();
            return RedirectToAction("Record");

        }

        [Authorize(Roles = "BookOwner")]
        public IActionResult Cancel(int id)
        {
            TempData["cancel"] = "Order has been cancelled";
            var order = context.Orders.Find(id);
            context.Orders.Remove(order);
            context.SaveChanges();
            return RedirectToAction("Record");

        }
    }
}
