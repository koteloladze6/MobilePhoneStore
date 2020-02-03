using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace MobilePhoneStore.Models
{
    public class PhoneModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Image { get; set; }

        public static explicit operator PhoneModel(Phone p)
        {
            return new PhoneModel()
            {
                ID = p.ID,
                Name = p.Name,
                Price = p.Price,
                Image = p.Image.Split('?')[0]
            };
        }

    }
}
