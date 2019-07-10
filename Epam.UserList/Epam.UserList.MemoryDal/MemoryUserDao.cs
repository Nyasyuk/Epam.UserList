using Epam.UserList.DalContract;
using Epam.UserList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UserList.MemoryDal
{
    public class MemoryUserDao : IUserDao
    {
        private readonly Dictionary<int, User> users;
        private int maxId;

        public MemoryUserDao()
        {
            users = new Dictionary<int, User>();
            maxId = 0;
        }

        public bool Add(User user)
        {
            user.Id = ++maxId;
            users.Add(maxId, user); 

            return true;
        }

        public bool DellById(int id)
        {
            users.Remove(id);

            return true;
        }

        public IEnumerable<User> GetAll()
        {
            foreach (var item in users)
            {
                yield return item.Value;
            }
        }

        public User GetById(int id)
        {
            return users[id];
        }

        public bool GiveAward(int idUser, Award userAward)
        {
            User newUser = GetById(idUser);
            newUser.Id = idUser;

            List <Award>newListAwards = newUser.Awards;
            newListAwards.Add(userAward);
            newUser.Awards = newListAwards;

            DellById(idUser);

            users.Add(newUser.Id, newUser);
            return true;
        }
    }
}
