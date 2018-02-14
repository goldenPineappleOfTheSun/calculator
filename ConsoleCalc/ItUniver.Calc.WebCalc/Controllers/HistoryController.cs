using ItUniver.Calc.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalc.Controllers
{
    [Authorize]
    public class HistoryController : Controller
    {
        // GET: History
        public ActionResult Index()
        {
            var history = DbHelper.GetAllHistoryItems()
                .OrderByDescending(o => o.ExecDate);

            return View(history);
        }
    }
}