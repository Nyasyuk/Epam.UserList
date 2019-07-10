using Epam.UserList.DalContract;
using Epam.UserList.MemoryDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UserList.Logic
{
    internal static class DaoProvider
    {
        static DaoProvider()
        {
            UserDao = new MemoryUserDao();
            AwardDao = new MemoryAwardDao();
        }

        public static IUserDao UserDao {get; }
        public static IAwardDao AwardDao { get; }
    }
}
