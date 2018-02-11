using ItUniver.Calc.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Repositories
{
    public interface IRepository
    {
        IHistoryItem Find(long id);

        void Save(IHistoryItem item);

        void Delete(long id);

        IList<IHistoryItem> GetAll();
    }
}
