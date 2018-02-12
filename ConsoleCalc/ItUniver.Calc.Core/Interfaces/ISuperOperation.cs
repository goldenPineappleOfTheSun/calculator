using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.Core.Interfaces
{
    public interface ISuperOperation : IOperation
    {
        string Owner { get; }

        string Description { get; }
    }
}
