using ItUniver.Calc.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.Core.Operations
{
    class SumOperation : IOperation
    {
        int IOperation.argsCount => 2;

        string IOperation.Name => "sum";

        public string Owner => "ItUniver";

        public string Description => "";

        double IOperation.Exec(double[] args)
        {
            return args.Aggregate((x, y) => x + y);
        }
    }
}
