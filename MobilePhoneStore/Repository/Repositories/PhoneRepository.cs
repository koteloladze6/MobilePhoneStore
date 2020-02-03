using System;
using System.Collections.Generic;
using System.Text;
using Domain.Interfaces;
using Domain;

namespace Repository.Repositories
{
    public class PhoneRepository : BaseRepository<Phone>, IPhoneRepository
    {
        public PhoneRepository(PhoneDbContext context) : base(context)
        {
        }
    }
}
