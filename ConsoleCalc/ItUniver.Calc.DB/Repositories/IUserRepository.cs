using ItUniver.Calc.DB.Repositories;
using System;
using ItUniver.Calc.DB.Models;
using NHibernate.Criterion;
using System.Linq;

namespace ITUniver.Calc.DB.NH.Repositories
{
    public interface IUserRepository : IBaseRepository<UserItem>
    {

        /// <summary>
        /// Проверить наличие пользователя с таким паролем
        /// </summary>
        /// <param name="login">Имя пользователя</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        bool Check(string login, string password);

        /// <summary>
        /// Загрузить пользователя по имени
        /// </summary>
        /// <param name="login">Имя пользователя</param>
        /// <returns></returns>
        UserItem GetByLogin(string login);
    }
}