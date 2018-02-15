using ItUniver.Calc.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Repositories
{
    interface IHistoryRepository
    {
        IEnumerable<HistoryItem> FindByUser(long user);

        IEnumerable<HistoryItem> FindByUserLogin(string user);
    }
}
