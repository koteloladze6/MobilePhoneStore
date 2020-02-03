using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MobilePhoneStore.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<PhoneModel> Phones { get; set; }

        public string SearchWord { get; set; }

        public double MinPrice { get; set; }

        public double MaxPrice { get; set; }

        public IEnumerable<SelectListItem> Manufacturers { get; set; }

        public int ManufacturerID { get; set; }

        public int Page { get; set; } = 1;

        public int PageSize { get; set; }

        public int TotalPages { get; set; }
    }
}
