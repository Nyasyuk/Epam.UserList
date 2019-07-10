using Epam.UserList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UserList.DalContract
{
    public interface IAwardDao
    {
        bool Add(Award award);

        IEnumerable<Award> GetAll();

        Award GetById(int id);
    }
}
