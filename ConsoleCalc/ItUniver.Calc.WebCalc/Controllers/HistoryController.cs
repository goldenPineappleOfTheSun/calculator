using ItUniver.Calc.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalc.Controllers
{
    public class HistoryController : Controller
    {
        // GET: History
        public ActionResult Index()
        {
            var history = ItUniver.Calc.WinFormApp.MyHelper.GetAllHistoryItems()
                .OrderByDescending(o => o.ExecDate);

            return View(history);
        }
    }
}