using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UserList.Entities
{
    public class User
    {
        int id;
        string name;
        DateTime dateOfBirth;
        List <Award> awards;

        public int Id {get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List <Award> Awards { get; set; }

        public User(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public User(string name, DateTime dateOfBirth, List <Award> awards)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Awards = awards;
        }
    }
}
