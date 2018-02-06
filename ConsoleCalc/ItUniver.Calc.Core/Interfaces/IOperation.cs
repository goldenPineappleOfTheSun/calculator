using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.Core.Interfaces
{
    public interface IOperation
    {
        int argsCount { get; }

        double Exec(double[] args);

        string Name { get; }
    }
}
