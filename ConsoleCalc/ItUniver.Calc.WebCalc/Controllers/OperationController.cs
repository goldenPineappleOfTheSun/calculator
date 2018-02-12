using ItUniver.Calc.WebCalc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItUniver.Calc.WebCalc.Controllers
{
    public class OperationController : Controller
    {
        // GET: Operation
        public ActionResult Index()
        {
            var model = new OperationViewModel();
            
            return View("Details", model);
        }
    }
}