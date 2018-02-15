using ItUniver.Calc.DB.Repositories;
using System;
using ItUniver.Calc.DB.Models;
using NHibernate.Criterion;
using System.Linq;
using ITUniver.Calc.DB.NH.Repositories;

namespace ItUniver.Calc.DB.NH.Repositories
{
    public class NhUserRepository : NhBaseRepository<UserItem>, IUserRepository
    {
        public bool Check(string login, string password)
        {
            var session = Helper.GetCurrentSession();

            return session
                .QueryOver<UserItem>()
                .And(u => u.Login == login && u.Password == password && u.Status == UserStatus.Active)
                .RowCount() > 0;

        }

        public UserItem GetByLogin(string login)
        {
            var session = Helper.GetCurrentSession();

            return session
                .QueryOver<UserItem>()
                .And(u => u.Login == login)
                .SingleOrDefault();

        }

    }
}