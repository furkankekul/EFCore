using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> Get();
        bool Add(T model);
        bool Remove(T model);
        int Save();
    }
}
