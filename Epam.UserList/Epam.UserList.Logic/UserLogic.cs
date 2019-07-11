using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.UserList.DalContract;
using Epam.UserList.Entities;
using Epam.UserList.LogicContracts;

namespace Epam.UserList.Logic
{
    public class UserLogic : IUserLogic
    {
        private IUserDao userDao;
        private IAwardDao awardDao;

        public UserLogic()
        {
            userDao = DaoProvider.UserDao;
            awardDao = DaoProvider.AwardDao;
        }

        public User Del(string idUser)
        {
            User user = userDao.GetById(Convert.ToInt32(idUser));
            if (userDao.DellById(Convert.ToInt32(idUser)))
            {
                return user;
            }

            throw new InvalidOperationException("Ошибка удаления");
        }

        public User[] GetAll()
        {
            return userDao.GetAll().ToArray();
        }

        public void GivAward(int idUser, int idAward)
        {
            Award userAward = awardDao.GetById(idAward);
            userDao.GiveAward(idUser, userAward);
        }

        public User Save(string userName, DateTime dateOfBirth)
        {
            if(string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentException("Имя пользователя не задано");
            }
            List<Award> userAwards = new List<Award>();
            User user = new User(userName, dateOfBirth, userAwards);

            if (userDao.Add(user))
            {
                return user;
            }

            throw new InvalidOperationException("Ошибка сохранения");
        }
    }
}
