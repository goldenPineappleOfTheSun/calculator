using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Models
{
    interface IHistoryItem : IEntity
    {
        long Operation { get; set; }

        UserItem UserId { get; set; }

        string Args { get; set; }

        double? Result { get; set; }

        DateTime ExecDate { get; set; }

        double ExecSpeed { get; set; }
    }
}
