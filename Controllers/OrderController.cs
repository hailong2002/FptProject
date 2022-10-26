using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FPTBook.Controllers
{
    public class OrderController : Controller
    {

        public ApplicationDbContext context { get; set; }

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult MakeOrder(int id, int quantity)
        {
            var order = new Order();
            order.OrderQuantity = quantity;
            order.BookId = id;
            //TempData["alo"] = context.Books.Find(id).Title;
            order.OrderName = context.Books.Find(id).Title;
            order.OrderPrice = (context.Books.Find(id).Price)*quantity;
            context.Orders.Add(order);
            context.Books.Find(id).Quantity -= quantity; 
            context.SaveChanges();
           
            return View(order);
        }
    }
}
