using ItUniver.Calc.DB.Repositories;
using System;
using ItUniver.Calc.DB.Models;
using NHibernate.Criterion;
using System.Linq;
using System.Collections.Generic;
using ITUniver.Calc.DB.NH.Repositories;

namespace ItUniver.Calc.DB.NH.Repositories
{
    public class NhHistoryRepository : NhBaseRepository<HistoryItem>, IHistoryRepository
    {
        public IEnumerable<HistoryItem> FindByUser(long user)
        {
            return new List<HistoryItem>();
        }
        public IEnumerable<HistoryItem> FindByUserLogin(string login)
        {
            return GetAll();
        }
    }
}