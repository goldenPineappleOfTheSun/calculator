using ItUniver.Calc.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Repositories
{
    public class MemoryRepository : IHistoryRepository
    {
        private IList<IHistoryItem> items = new List<IHistoryItem>();

        public IHistoryItem Find(long id)
        {
            throw new NotImplementedException();
        }

        public void Save(IHistoryItem item)
        {
            items.Add(item);
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IList<IHistoryItem> GetAll()
        {
            return items;
        }
    }
}
