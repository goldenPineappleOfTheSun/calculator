using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalc.Models
{
    public class OperationModel
    {
        [Display(Name = "Операция")]
        public string Operation { get; set; }

        [Display(Name = "Список операций")]
        public List<SelectListItem> AllOperations { get; set; }

        [Display(Name = "Аргументы")]
        public IEnumerable<double> Args { get; set; }

        [Display(Name = "Результ")]
        [ReadOnly(true)]
        public double? Result { get; set; }

    }
}