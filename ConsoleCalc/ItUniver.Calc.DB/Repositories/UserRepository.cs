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
            // TODO: Make it better
            return GetAll().Any(u => u.Login == login && u.Password == password);

            return true;
        }

        /// <summary>
        /// Найти пользователя по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public UserItem FindByName(string name)
        {
            return new UserItem();
        }
    }
}
