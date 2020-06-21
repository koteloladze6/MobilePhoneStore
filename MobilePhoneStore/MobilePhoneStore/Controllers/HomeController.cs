using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobilePhoneStore.Models;
using Repository;
using Domain.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using MobilePhoneStore.Helpers;

namespace MobilePhoneStore.Controllers
{
    public class HomeController : Controller
    {
        private IPhoneRepository _phoneRepository { get; set; }

        private IManufacturerRepository _manufacturerRepository { get; set; }

        private Cart _cart;

        public HomeController(IPhoneRepository phoneRepository, IManufacturerRepository manufacturerRepository, Cart cart)
        {
            _phoneRepository = phoneRepository;
            _manufacturerRepository = manufacturerRepository;
            _cart = cart;
        }

        public IActionResult Index(int minPrice, int maxPrice, string searchText = null, int page = 1, int manufacturerID=0)
        {
            int totalpages;

            ProductListViewModel model = new ProductListViewModel
            {
                Phones = GetPhones(minPrice, maxPrice, searchText, 8, page, manufacturerID, out totalpages),
                SearchWord = searchText,
                MinPrice = minPrice,
                MaxPrice = maxPrice,
                Page = page,
                TotalPages = totalpages,
                Manufacturers = GetManufacturerList(),
                CartQuantity = _cart.Items.Sum(q => q.Quantity)
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ProductListViewModel model)
        {
            return RedirectToAction("Index", new
            {
                minPrice = model.MinPrice,
                maxPrice = model.MaxPrice,
                searchText = model.SearchWord,
                Page = model.Page,
                manufacturerID= model.ManufacturerID,
                TotalPages = model.TotalPages,
                CartQuantity = _cart.Items.Sum(q => q.Quantity)
            });
        }

        public IActionResult Details(int id)
        {
            var model =(PhoneDetailsModel)_phoneRepository.Get(id);

            return View(model);
        }

        public IEnumerable<PhoneModel> GetPhones(int minPrice, int maxPrice, string searchText, int pageSize, int page, int manufacturerID, out int totalPages)
        {
            var phones = _phoneRepository.GetRange().Where(p => (searchText == null || searchText == String.Empty || p.Name.ToLower().Contains(searchText.ToLower().Trim())) &&
                                                                ((minPrice == 0 || p.Price >= minPrice) && (maxPrice == 0 || p.Price <= maxPrice)) &&
                                                                (manufacturerID == 0 || p.ManufacturerID == manufacturerID))
                                                                .Select(p => (PhoneModel)p);

            totalPages = (int)Math.Ceiling((decimal)phones.Count() / pageSize);

            return phones.Skip(pageSize * (page-1)).Take(pageSize);
        }

        public IEnumerable<SelectListItem> GetManufacturerList()
        {
            return _manufacturerRepository.GetRange().Select(m => new SelectListItem() { Value = m.ID.ToString(), Text = m.Name });
        }
    }
}
