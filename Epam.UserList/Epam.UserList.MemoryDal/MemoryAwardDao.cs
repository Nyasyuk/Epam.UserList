using Epam.UserList.DalContract;
using Epam.UserList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UserList.MemoryDal
{
    public class MemoryAwardDao : IAwardDao
    {
        private readonly Dictionary<int, Award> awards;
        private int maxId;

        public MemoryAwardDao()
        {
            awards = new Dictionary<int, Award>();
            maxId = 0;
        }

        public bool Add(Award award)
        {
            award.Id = ++maxId;
            awards.Add(maxId, award);

            return true;
        }

        public IEnumerable<Award> GetAll()
        {
            foreach (var item in awards)
            {
                yield return item.Value;
            }
        }

        public Award GetById(int id)
        {
            return awards[id];
        }
    }
}
