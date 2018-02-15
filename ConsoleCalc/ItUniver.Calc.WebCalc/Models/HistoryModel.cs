using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebCalc.Models
{
    public class HistoryModel
    {
        public string Operation { get; set; }

        public IEnumerable<double> Args { get; set; }

        public double? Result { get; set; }

        public double? ExecSpeed { get; set; }
    }
}