using ItUniver.Calc.DB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Repositories
{
    public class UserRepository : BaseRepository<UserItem>
    {
        public UserRepository(string tableName) : base(tableName)
        {
        }

        /// <summary>
        /// Проверить наличие пользователя с таким логином/паролем
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Check(string login, string password)
        {
            var count = base.ReadData($"Login='{login}' AND Password='{password}'")
                .Count();
            var result = (count > 0) ? true : false;

            return result;
        }

        /// <summary>
        /// Найти пользователя по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public UserItem FindByLogin(string login)
        {
            // TODO: When no user found
            var result = base.ReadData($"Login='{login}'");

            return result.FirstOrDefault();
        }
    }
}
