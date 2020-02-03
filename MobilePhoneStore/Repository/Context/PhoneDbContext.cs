using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Repository
{
    public class PhoneDbContext : DbContext
    {
        public PhoneDbContext(DbContextOptions<PhoneDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

    }
}
