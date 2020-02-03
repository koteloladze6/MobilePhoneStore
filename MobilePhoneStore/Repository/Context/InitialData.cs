using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Domain;

namespace Repository
{
    public static class InitialData
    {
        public static void Seed(PhoneDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Phones.Any())
            {
                List<Manufacturer> ManufacturersList = new List<Manufacturer>()
                {
                    new Manufacturer{ Name = "Samsung" },
                    new Manufacturer{ Name = "Apple" },
                    new Manufacturer{ Name = "Sony" },
                    new Manufacturer{ Name = "Huawei" },
                    new Manufacturer{ Name = "Nokia" },
                    new Manufacturer{ Name = "LG" }
                 };
                context.Manufacturers.AddRange(ManufacturersList);
                context.SaveChanges();
            
                List<Phone> phones = new List<Phone>()
                {
                    new Phone
                    {
                        Name="Iphone 7",
                        CPU="A10 Fusion",
                        Dimension="67.1 x 138.3 x 7.1",
                        Memory="32 GB",
                        Weight=138,
                        OS="IOS",
                        Image="Iphone 7/iphone 7.jpg?Iphone 7/iphone 7-1.jpg?Iphone 7/iphone 7-2.jpg",
                        Video="https://www.youtube.com/embed/IjJCXb9OxZM",
                        Display="4.7",
                        Price=500,
                        ManufacturerID=2,
                        Manufacturer=context.Manufacturers.Find(2)
                    },
                    new Phone
                    {
                        Name="iPhone 11",
                        CPU="Hexa-core",
                        Dimension="150.9 x 75.7 x 8.3",
                        Memory="128 GB",
                        Weight=194,
                        OS="IOS",
                        Image="Iphone 11/iphone 11.jpg?Iphone 11/iphone 11-1.jpg?Iphone 11/iphone 11-2.jpg",
                        Video="https://www.youtube.com/embed/OoY7zp8GkLI",
                        Display="6.1",
                        Price=1200,
                        ManufacturerID=2,
                        Manufacturer=context.Manufacturers.Find(2)
                    },

                    new Phone
                    {
                        Name="iPhone XS",
                        CPU="A12 Bionic",
                        Dimension="70.9 x 143.6 x 7.7",
                        Memory="64 GB",
                        Weight=194,
                        OS="IOS",
                        Image="Iphone XS/iphone XS.jpg?Iphone XS/iphone XS-1.jpg?Iphone XS/iphone XS-2.jpg",
                        Video="https://www.youtube.com/embed/YAF9BWpzwvI",
                        Display="5.8",
                        Price=900,
                        ManufacturerID=2,
                        Manufacturer=context.Manufacturers.Find(2)
                    },
                    new Phone {
                        Name = "Galaxy A9",
                        Dimension = "162.5 x 77 x 7.8",
                        Weight = 183,
                        Display = "6.3",
                        CPU = "Octa-core",
                        Memory = "128 GB",
                        OS = "Android 8.0 (Oreo)",
                        Price = 360,
                        Image = "Samsung Galaxy A9 (2018)/samsung-galaxy-a9-2018.jpg?Samsung Galaxy A9 (2018)/samsung-galaxy-a9-2018-2.jpg?Samsung Galaxy A9 (2018)/samsung-galaxy-a9-2018-3.jpg",
                        Video="https://www.youtube.com/embed/G7EorvF65Pk",
                        ManufacturerID = 1,
                        Manufacturer = context.Manufacturers.Find(1),
                    },
                    new Phone {
                        Name = "Galaxy Note9",
                        Dimension = "161.9 x 76.4 x 8.8",
                        Weight = 201,
                        Display = "6.4",
                        CPU = "Octa-core",
                        Memory = "512 GB",
                        OS = "Android 8.1 (Oreo)",
                        Price = 750,
                        Image = "Samsung Galaxy Note9/samsung-galaxy-note9-r1.jpg?Samsung Galaxy Note9/samsung-galaxy-note9-r3.jpg?Samsung Galaxy Note9/samsung-galaxy-note9-r4.jpg",
                        Video="https://www.youtube.com/embed/ihEhAbVRC78",
                        ManufacturerID = 1,
                        Manufacturer = context.Manufacturers.Find(1),
                    },
                    new Phone {
                        Name = "Xperia XA2",
                        Dimension = "163 x 80 x 9.5",
                        Weight = 221,
                        Display = "6.0",
                        CPU = "Octa-core",
                        Memory = "64 GB",
                        OS = "Android 8.0 (Oreo)",
                        Price = 330,
                        Image = "Sony Xperia XA2 Ultra/sony-xperia-xa2-ultra.jpg?Sony Xperia XA2 Ultra/sony-xperia-xa2-ultra-2.jpg?Sony Xperia XA2 Ultra/sony-xperia-xa2-ultra-3.jpg",
                        Video="https://www.youtube.com/embed/aVPeOn73ERY",
                        ManufacturerID = 3,
                        Manufacturer = context.Manufacturers.Find(3),
                    },
                    new Phone
                    {
                        Name="Iphone 7",
                        CPU="A10 Fusion",
                        Dimension="67.1 x 138.3 x 7.1",
                        Memory="32 GB",
                        Weight=138,
                        OS="IOS",
                        Image="Iphone 7/iphone 7.jpg?Iphone 7/iphone 7-1.jpg?Iphone 7/iphone 7-2.jpg",
                        Video="https://www.youtube.com/embed/IjJCXb9OxZM",
                        Display="4.7",
                        Price=500,
                        ManufacturerID=2,
                        Manufacturer=context.Manufacturers.Find(2)
                    },
                    new Phone
                    {
                        Name="iPhone 11",
                        CPU="Hexa-core",
                        Dimension="150.9 x 75.7 x 8.3",
                        Memory="128 GB",
                        Weight=194,
                        OS="IOS",
                        Image="Iphone 11/iphone 11.jpg?Iphone 11/iphone 11-1.jpg?Iphone 11/iphone 11-2.jpg",
                        Video="https://www.youtube.com/embed/OoY7zp8GkLI",
                        Display="6.1",
                        Price=1200,
                        ManufacturerID=2,
                        Manufacturer=context.Manufacturers.Find(2)
                    },

                    new Phone
                    {
                        Name="iPhone XS",
                        CPU="A12 Bionic",
                        Dimension="70.9 x 143.6 x 7.7",
                        Memory="64 GB",
                        Weight=194,
                        OS="IOS",
                        Image="Iphone XS/iphone XS.jpg?Iphone XS/iphone XS-1.jpg?Iphone XS/iphone XS-2.jpg",
                        Video="https://www.youtube.com/embed/YAF9BWpzwvI",
                        Display="5.8",
                        Price=900,
                        ManufacturerID=2,
                        Manufacturer=context.Manufacturers.Find(2)
                    },
                    new Phone {
                        Name = "Galaxy A9",
                        Dimension = "162.5 x 77 x 7.8",
                        Weight = 183,
                        Display = "6.3",
                        CPU = "Octa-core",
                        Memory = "128 GB",
                        OS = "Android 8.0 (Oreo)",
                        Price = 360,
                        Image = "Samsung Galaxy A9 (2018)/samsung-galaxy-a9-2018.jpg?Samsung Galaxy A9 (2018)/samsung-galaxy-a9-2018-2.jpg?Samsung Galaxy A9 (2018)/samsung-galaxy-a9-2018-3.jpg",
                        Video="https://www.youtube.com/embed/G7EorvF65Pk",
                        ManufacturerID = 1,
                        Manufacturer = context.Manufacturers.Find(1),
                    },
                    new Phone {
                        Name = "Galaxy Note9",
                        Dimension = "161.9 x 76.4 x 8.8",
                        Weight = 201,
                        Display = "6.4",
                        CPU = "Octa-core",
                        Memory = "512 GB",
                        OS = "Android 8.1 (Oreo)",
                        Price = 750,
                        Image = "Samsung Galaxy Note9/samsung-galaxy-note9-r1.jpg?Samsung Galaxy Note9/samsung-galaxy-note9-r3.jpg?Samsung Galaxy Note9/samsung-galaxy-note9-r4.jpg",
                        Video="https://www.youtube.com/embed/ihEhAbVRC78",
                        ManufacturerID = 1,
                        Manufacturer = context.Manufacturers.Find(1),
                    },
                    new Phone {
                        Name = "Xperia XA2",
                        Dimension = "163 x 80 x 9.5",
                        Weight = 221,
                        Display = "6.0",
                        CPU = "Octa-core",
                        Memory = "64 GB",
                        OS = "Android 8.0 (Oreo)",
                        Price = 330,
                        Image = "Sony Xperia XA2 Ultra/sony-xperia-xa2-ultra.jpg?Sony Xperia XA2 Ultra/sony-xperia-xa2-ultra-2.jpg?Sony Xperia XA2 Ultra/sony-xperia-xa2-ultra-3.jpg",
                        Video="https://www.youtube.com/embed/aVPeOn73ERY",
                        ManufacturerID = 3,
                        Manufacturer = context.Manufacturers.Find(3),
                    },
                    new Phone {
                        Name = "Xperia XA2",
                        Dimension = "163 x 80 x 9.5",
                        Weight = 221,
                        Display = "6.0",
                        CPU = "Octa-core",
                        Memory = "64 GB",
                        OS = "Android 8.0 (Oreo)",
                        Price = 330,
                        Image = "Sony Xperia XA2 Ultra/sony-xperia-xa2-ultra.jpg?Sony Xperia XA2 Ultra/sony-xperia-xa2-ultra-2.jpg?Sony Xperia XA2 Ultra/sony-xperia-xa2-ultra-3.jpg",
                        Video="https://www.youtube.com/embed/aVPeOn73ERY",
                        ManufacturerID = 3,
                        Manufacturer = context.Manufacturers.Find(3),
                    }
                };
                context.Phones.AddRange(phones);
                context.SaveChanges();
            }
        }
    }
}
