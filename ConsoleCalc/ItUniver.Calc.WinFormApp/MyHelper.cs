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
        private static IHistoryRepository History = new MemoryRepository();

        public static void AddToHistory(string oper, double[] args, double result)
        {
            var item = new HistoryItem();
            item.Args = string.Join(" ", args);
            item.Operation = oper;
            item.Result = result;
            item.ExecDate = DateTime.Now;

            History.Save(item);
        }
    }
}
