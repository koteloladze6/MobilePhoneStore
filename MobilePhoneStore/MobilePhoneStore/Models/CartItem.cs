using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilePhoneStore.Models
{
    public class CartItem
    {
        public int ID { get; set; }

        public PhoneDetailsModel Phone { get; set; }

        public int Quantity { get; set; }

    }
}
