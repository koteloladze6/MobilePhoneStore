using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MobilePhoneStore.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MobilePhoneStore.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
            .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart")
            ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(PhoneDetailsModel phone, int quantity)
        {
            base.AddItem(phone, quantity);
            Session.SetObjectAsJson("Cart", this);
        }

        public override void RemoveItem(PhoneDetailsModel phone)
        {
            base.RemoveItem(phone);
            Session.SetObjectAsJson("Cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
    