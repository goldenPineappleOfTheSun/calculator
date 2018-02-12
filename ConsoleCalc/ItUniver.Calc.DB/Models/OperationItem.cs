using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Models
{
    public class OperationItem : IOperationItem
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Owner { get; set; }

        public int ArgsCount { get; set; }

        public DateTime CreationDate { get; set; }

        /*public OperationItem(long id, string name, string owner, int args, DateTime date)
        {
            Id = id;
            Name = name;
            Owner = owner;
            ArgsCount = args;
            CreationDate = date;
        }*/
    }
}
