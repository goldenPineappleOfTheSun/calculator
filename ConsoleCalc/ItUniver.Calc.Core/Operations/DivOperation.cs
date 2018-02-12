using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItUniver.Calc.Core.Interfaces;

namespace ItUniver.Calc.Core.Operations
{
    public class DivOperation : ISuperOperation
    {
        public int argsCount => 2;

        public string Name => "div";

        public string Owner => "ItUniver";

        public string Description => "";

        public double Exec(double[] args)
        {
            return args.Aggregate((x, y) => x / y);
        }
    }
}