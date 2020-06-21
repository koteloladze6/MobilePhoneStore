using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilePhoneStore.Models
{
    public class Cart
    {
        private List<CartItem> cartItemsList = new List<CartItem>();

        public virtual void AddItem(PhoneDetailsModel phone, int quantity)
        {
            var cartItems = cartItemsList.Where(p => p.Phone.ID == phone.ID).FirstOrDefault();

            if (cartItems == null)
            {
                cartItemsList.Add(new CartItem
                {
                    Phone = phone,
                    Quantity = quantity
                });
            }

            else
            {
                cartItems.Quantity += quantity;
            }
        }

        public virtual void RemoveItem(PhoneDetailsModel phone)
        {
            cartItemsList.RemoveAll(p => p.Phone.ID == phone.ID);
        }

        public virtual decimal TotalValue() => cartItemsList.Sum(p => p.Phone.Price * p.Quantity);

        public virtual void Clear() => cartItemsList.Clear();

        public virtual IEnumerable<CartItem> Items => cartItemsList;
    }
}
