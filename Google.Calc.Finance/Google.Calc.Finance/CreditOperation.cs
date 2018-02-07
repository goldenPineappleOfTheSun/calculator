using ItUniver.Calc.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Calc.Finance
{
    class CreditOperation : IOperation
    {
        int IOperation.argsCount => 2;

        string IOperation.Name => "credit";

        double IOperation.Exec(double[] args)
        {
            return args.Aggregate((x, y) => (x * 1.094) / x);
        }
    }
}
