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
        int age;
        List <Award> awards;

        public int Id {get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public List <Award> Awards { get; set; }

        public User(string name, DateTime dateOfBirth, int age)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Age = age;
        }

        public User(string name, DateTime dateOfBirth, int age, List <Award> awards)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Age = age;
            Awards = awards;
        }
    }
}
