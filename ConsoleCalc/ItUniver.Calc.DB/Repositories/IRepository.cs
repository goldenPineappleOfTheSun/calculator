using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Repositories
{
    public interface IRepository<T>
    {
        T Find(long id);

        void Save(T item);

        void Delete(long id);

        IList<T> GetAll();
    }
}
