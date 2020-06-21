using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MobilePhoneStore.Helpers;
using MobilePhoneStore.Models;

namespace MobilePhoneStore.Controllers
{
    public class CartController : Controller
    {
        private IPhoneRepository _phoneRepository;
        private Cart _cart;

        public CartController(IPhoneRepository phoneRepository, Cart cart)
        {
            _phoneRepository = phoneRepository;
            _cart = cart;
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new CartViewModel { Cart = _cart, ReturnUrl = returnUrl });
        }

        
        public RedirectToActionResult AddToCart(int productId, string returnUrl)
        {
            PhoneDetailsModel phone = (PhoneDetailsModel)_phoneRepository.GetRange().FirstOrDefault(p => p.ID == productId);

            if (phone != null)
            {
                _cart.AddItem(phone, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            PhoneDetailsModel phone = (PhoneDetailsModel)_phoneRepository.GetRange().FirstOrDefault(p => p.ID == productId);

            if (phone != null)
            {
                _cart.RemoveItem(phone);
            }

            return RedirectToAction("Index", new { returnUrl });
        }
    }
}