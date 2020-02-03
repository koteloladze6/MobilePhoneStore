using System;
using System.Collections.Generic;
using System.Text;
using Domain.Interfaces;

namespace Repository.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected PhoneDbContext _context;

        internal BaseRepository(PhoneDbContext context)
        {
            _context = context;
        }
        public T Get(int id)
        {
           return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetRange()
        {
            return _context.Set<T>();
        }
    }
}
