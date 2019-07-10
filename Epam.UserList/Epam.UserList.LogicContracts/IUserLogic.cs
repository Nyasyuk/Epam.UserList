using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.UserList.Entities;

namespace Epam.UserList.LogicContracts
{
    public interface IUserLogic
    {
        User Del(string idUser);
        User Save(string userName, DateTime dateOfBirth, int age);
        User[] GetAll();
        void GivAward(int idUser, int userAward);
    }
}
