using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace MobilePhoneStore.Models
{
    public class PhoneDetailsModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Dimension { get; set; }

        public int Weight { get; set; }

        public string Display { get; set; }

        public string CPU { get; set; }

        public string Memory { get; set; }

        public string OS { get; set; }

        public int Price { get; set; }

        public string[] Images { get; set; }

        public string Video { get; set; }

        public string Manufacturer { get; set; }

        public static explicit operator PhoneDetailsModel(Phone p)
        {
            return new PhoneDetailsModel
            {
                ID = p.ID,
                Name = p.Name,
                Dimension = p.Dimension,
                Weight = p.Weight,
                Display = p.Display,
                CPU = p.CPU,
                Memory = p.Memory,
                OS = p.OS,
                Price = p.Price,
                Images = p.Image.Split('?'),
                Manufacturer = p.Manufacturer.Name,
                Video=p.Video
            };
        }
    }
}
