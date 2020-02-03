using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetRange();
    }
}
