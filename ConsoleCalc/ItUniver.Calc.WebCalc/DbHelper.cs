﻿using ItUniver.Calc.DB.Models;
using ItUniver.Calc.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalc
{
    public static class DbHelper
    {
        // TODO: Актуализировать базу операций

        private static HistoryRepository History = new HistoryRepository("History");
        public static OperationRepository Operations = new OperationRepository("Operation");

        public static OperationItem FindOperation(long id)
        {
            return ItUniver.Calc.WinFormApp.MyHelper.Operations.Find(id);
        }

        public static int FindOperationById()
        {
            return 2;
        }

        public static void AddToHistory(string oper, double[] args, double result)
        {
            var item = new HistoryItem();
            //TODO: вычислить ид операции
            item.Operation = Operations.FindByName(oper).Id;
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