
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        
        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string Line3 { get; set; }

        public string City { get; set; }
        
        public string State { get; set; }

        public string Zip { get; set; }
       
        public string Country { get; set; }

        public bool GiftWrap { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalPrice { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
}
