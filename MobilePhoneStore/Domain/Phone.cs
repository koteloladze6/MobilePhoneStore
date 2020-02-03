using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Phone
    {
        private readonly ILazyLoader _lazyLoader;
        private Manufacturer _manufacturer;
        public Phone()
        {
        }

        public Phone(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }

        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public string Dimension { get; set; }

        public int Weight { get; set; }

        public string Display { get; set; }

        public string CPU { get; set; }

        public string Memory { get; set; }

        public string OS { get; set; }
        
        public int Price { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Video { get; set; }

        public int ManufacturerID { get; set; }

        public virtual Manufacturer Manufacturer 
        {
            get => _lazyLoader.Load(this, ref _manufacturer);
            set => _manufacturer = value;
        }
    }
}
