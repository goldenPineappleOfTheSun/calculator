using ItUniver.Calc.DB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Repositories
{
    public class OperationRepository : BaseRepository<OperationItem>
    {
        public OperationRepository(string tableName) : base(tableName)
        {
        }

        public OperationItem FindByName(string name)
        {
            var result = base.ReadData().Where(i => i.Name == name);

            return result.First();
        }
    }
}
