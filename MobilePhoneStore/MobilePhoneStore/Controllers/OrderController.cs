using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MobilePhoneStore.Models;

namespace MobilePhoneStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository _orderRepository;

        private IOrderItemRepository _orderItemRepository;

        private IPhoneRepository _phoneRepository;

        private IManufacturerRepository _manufacturerRepository;

        private Cart _cart;

        public OrderController(IOrderRepository orderRepository, Cart cart, IPhoneRepository phoneRepository, 
            IManufacturerRepository manufacturerRepository, IOrderItemRepository orderItemRepository)
        {
            _orderRepository = orderRepository;

            _orderItemRepository = orderItemRepository;

            _phoneRepository = phoneRepository;

            _manufacturerRepository = manufacturerRepository;

            _cart = cart;
        }

        public ViewResult CheckOut()
        {
            return View(new OrderModel());
        }

        [HttpPost]
        public IActionResult CheckOut(OrderModel order)
        {
            if (_cart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                PlaceOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }

        public IActionResult Completed()
        {
            _cart.Clear();
            return RedirectToAction("index", "Home");
        }

        public void PlaceOrder(OrderModel orderModel)
        {
            var phones = _cart.Items.Select(p => p.Phone).ToList();
            var order = PrepareOrder(orderModel);

            foreach (var p in phones)
            {
                string image = "";
                foreach (var img in p.Images)
                {
                    if (string.IsNullOrWhiteSpace(image))
                    {
                        image += img;
                    }
                    else
                    {
                        image += "?" + img;
                    }
                }

                var manufacturer = _manufacturerRepository.GetRange().Where(m => m.Name == p.Manufacturer).FirstOrDefault();

                var phone = _phoneRepository.GetRange().Where(ph => ph.Name == p.Name).First();


                var orderItem = PrepareOrderItem(phone, order, p.ID);

                _orderItemRepository.SaveOrderItem(orderItem);
            }

            _orderRepository.SaveOrder(order);
        }

        public Order PrepareOrder(OrderModel orderModel)
        {
            orderModel.Phones = _cart.Items.Select(p => p.Phone).ToList();

            var order = new Order
            {
                Name = orderModel.Name,
                Line1 = orderModel.Line1,
                Line2 = orderModel.Line2,
                Line3 = orderModel.Line3,
                City = orderModel.City,
                Country = orderModel.Country,
                Zip = orderModel.Zip,
                GiftWrap = orderModel.GiftWrap,
                State = orderModel.State,
                OrderDate = DateTime.UtcNow,
                TotalPrice = orderModel.Phones.Sum(p => p.Price)
            };

            return order;
        }

        public OrderItem PrepareOrderItem(Phone phone, Order order, int id)
        {
            var quantity = _cart.Items.Where(p => p.Phone.ID == id).FirstOrDefault().Quantity;
            var orderItem = new OrderItem
            {
                Order = order,
                phone = phone,
                Price = phone.Price * quantity,
                Quantity = quantity
            };

            return orderItem;
        }
    }
}