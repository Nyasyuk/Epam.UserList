using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UserList.Entities
{
    public class Award
    {
        int id;
        string title;

        public int Id { get; set; }
        public string Title { get; set; }

        public Award(string title)
        {
            Title = title ;
        }
    }
}
