using ItUniver.Calc.DB.Models;
using ItUniver.Calc.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.WinFormApp
{
    public static class MyHelper
    {
        private static BaseRepository<HistoryItem> History = new BaseRepository<HistoryItem>("History");
        public static BaseRepository<OperationItem> Operations = new BaseRepository<OperationItem>("Operation");

        public static void AddToHistory(string oper, double[] args, double result)
        {
            var item = new HistoryItem();
            //TODO: вычислить ид операции
            item.Operation = 35;
            item.Args = string.Join(" ", args);
            item.Result = result;
            item.ExecDate = DateTime.Now;

            History.Save(item);
        }

        public static IList<HistoryItem> GetAllHistoryItems()
        {
            return History.GetAll().ToList();
        }

        public static void AddToOperations(string name, string owner, int argsCount)
        {
            var item = new OperationItem();
            item.Id = 0;
            item.Owner = owner;
            item.ArgsCount = argsCount;
            item.CreationDate = DateTime.Now;

            Operations.Save(item);
        }

        public static IEnumerable<OperationItem> GetAllOperationItems()
        {
            return Operations.GetAll();
        }
    }
}
