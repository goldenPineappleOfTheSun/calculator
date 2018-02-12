using ItUniver.Calc.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Repositories
{
    public interface IBaseRepository<T>
         where T : IEntity
    {
        T Find(long id);

        void Save(T item);

        void Delete(long id);

        IEnumerable<T> GetAll();
    }
}
