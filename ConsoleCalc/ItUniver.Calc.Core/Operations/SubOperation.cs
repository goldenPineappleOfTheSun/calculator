using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItUniver.Calc.Core.Interfaces;

namespace ItUniver.Calc.Core.Operations
{
    class SubOperation : IOperation
    {
        int IOperation.argsCount => 2;

        string IOperation.Name => "sub";

        double IOperation.Exec(double[] args)
        {
            return args.Aggregate((x, y) => x - y);
        }
    }
}
