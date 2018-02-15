using ConsoleCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCalc.Models;
using System.Diagnostics;
using System.Threading;

namespace WebCalc.Controllers
{
    [Authorize]
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            var model = new OperationModel();

            var operations = new List<SelectListItem>();
            operations.AddRange(
                DbHelper.GetAllOperationItems()
                .Select(o => new SelectListItem
                {
                    Text = o.Name,
                    Value = o.Name
                })
                );

            model.AllOperations = operations;

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(OperationModel model)
        {
            var calc = new Calculator();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            model.Result = calc.Exec(model.Operation, model.Args.ToArray());

            stopWatch.Stop();
            var speed = stopWatch.ElapsedMilliseconds;

            // TODO: закжшировать список операций
            // TODO: сохранять последнюю операцию
            var operations = new List<SelectListItem>();
            operations.AddRange(
                DbHelper.GetAllOperationItems()
                .Select(o => new SelectListItem
                {
                    Text = o.Name,
                    Value = o.Name
                })
                .Reverse()
                );

            model.AllOperations = operations;

            if (model.Operation != null && model.Args != null)
                DbHelper.AddToHistory(model.Operation, User.Identity.Name, model.Args.ToArray(), (double)model.Result, speed);

            return View(model);
        }
    }
}