using System;
using System.Collections;
using System.Collections.Generic;

namespace FPTBook.Models
{
    public class Order
    {
        public int Id { get; set; } 
        public string Customer { get; set; }

        public DateTime OrderDate { get; set; }

        public int OrderQuantity { get; set; }

        public double OrderPrice { get; set; }

        public string OrderName { get; set; }
        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
