using Epam.UserList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UserList.LogicContracts
{
    public interface IAwardLogic
    {
        Award Save(string title);
        Award[] GetAll();
    }
}
