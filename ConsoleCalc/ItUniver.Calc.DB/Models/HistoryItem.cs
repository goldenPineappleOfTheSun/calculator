using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Models
{
    public class HistoryItem : IHistoryItem
    {
        public virtual long Id { get; set; }

        public virtual long Operation { get; set; }

        public virtual string Args { get; set; }

        public virtual double? Result { get; set; }

        public virtual DateTime ExecDate { get; set; }

        public virtual UserItem UserId { get; set; }
    }
}
