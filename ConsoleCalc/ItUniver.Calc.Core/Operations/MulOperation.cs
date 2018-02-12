using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItUniver.Calc.Core.Interfaces;

namespace ItUniver.Calc.Core.Operations
{
    class MulOperation : IOperation
    {
        int IOperation.argsCount => 2;

        string IOperation.Name => "mul";

        public string Owner => "ItUniver";

        public string Description => "";

        double IOperation.Exec(double[] args)
        {
            return args.Aggregate((x, y) => x * y);
        }
    }
}