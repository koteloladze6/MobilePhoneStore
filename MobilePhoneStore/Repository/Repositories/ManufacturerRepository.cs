using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Domain.Interfaces;

namespace Repository.Repositories
{
    public class ManufacturerRepository : BaseRepository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(PhoneDbContext context) : base(context)
        {
        }
    }
}
