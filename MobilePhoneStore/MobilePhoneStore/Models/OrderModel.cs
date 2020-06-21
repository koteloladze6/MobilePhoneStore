using Domain;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobilePhoneStore.Models
{
    public class OrderModel
    {
        [BindNever]
        public int OrderID { get; set; }

        [BindNever]
        public ICollection<PhoneDetailsModel> Phones { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line")]
        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }

        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter a country name")]

        public string Country { get; set; }

        public bool GiftWrap { get; set; }

        public static explicit operator Order(OrderModel order)
        {
            return new Order
            {
                OrderID = order.OrderID,
                Name = order.Name,
                Line1 = order.Line1,
                Line2 = order.Line2,
                Line3 = order.Line3,
                City = order.City,
                State = order.State,
                Zip = order.Zip,
                Country = order.Country,
                GiftWrap = order.GiftWrap
            };
        }
    }
}
