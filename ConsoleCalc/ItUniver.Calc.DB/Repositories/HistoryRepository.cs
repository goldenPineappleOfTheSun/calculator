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

        public IEnumerable<HistoryItem> FindByUser(long user)
        {
            var result = base.ReadData($"UserId='{user}'");

            return result;
        }

        public IEnumerable<HistoryItem> FindByUserLogin(string login)
        {
            var userRep = new UserRepository();

            var user = userRep.GetByLogin(login);

            return GetAll($"[Author] = {user.Id}");
        }
    }
}
