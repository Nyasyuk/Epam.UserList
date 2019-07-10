using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.UserList.Entities;

namespace Epam.UserList.DalContract
{
    public interface IUserDao
    {
        bool Add(User user);

        bool DellById(int id);

        IEnumerable<User> GetAll();

        User GetById(int id);

        bool GiveAward(int idUser, Award newAward);
    }
}
