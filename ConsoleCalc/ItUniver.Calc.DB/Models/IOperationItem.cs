using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Models
{
    interface IOperationItem : IEntity
    {
        string Name { get; set; }

        string Owner { get; set; }

        int ArgsCount { get; set; }

        DateTime CreationDate { get; set; }
    }
}
