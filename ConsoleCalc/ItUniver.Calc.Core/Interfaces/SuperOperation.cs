using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.Core.Interfaces
{
    public abstract class SuperOperation : ISuperOperation
    {
        public virtual int argsCount => 2;

        public virtual string Description => "";

        public virtual string Name => "noname";

        public virtual string Owner => "ITUniver Company";

        public abstract double Exec(double[] args);

        public string OwnerName
        {
            get
            {
                return $"{Owner} / {Name}";
            }
        }
    }
}
