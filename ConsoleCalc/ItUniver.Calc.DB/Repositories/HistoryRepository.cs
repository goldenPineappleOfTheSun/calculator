using ItUniver.Calc.DB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Repositories
{
    public class HistoryRepository : BaseRepository<HistoryItem>
    {
        public HistoryRepository(string tableName) : base(tableName)
        {
        }

        public IEnumerable<HistoryItem> FindByUserLogin(long user)
        {
            var result = base.ReadData($"UserId='{user}'");

            return result;
        }
    }
}
