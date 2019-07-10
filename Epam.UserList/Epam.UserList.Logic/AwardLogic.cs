using Epam.UserList.DalContract;
using Epam.UserList.Entities;
using Epam.UserList.LogicContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UserList.Logic
{
    public class AwardLogic : IAwardLogic
    {
        private IAwardDao awardDao;

        public AwardLogic()
        {
            awardDao = DaoProvider.AwardDao;
        }

        public Award[] GetAll()
        {
            return awardDao.GetAll().ToArray();
        }

        public Award Save(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Название награды не задано");
            }
            Award award = new Award(title);

            if (awardDao.Add(award))
            {
                return award;
            }

            throw new InvalidOperationException("Ошибка сохранения");
        }
    }
}
