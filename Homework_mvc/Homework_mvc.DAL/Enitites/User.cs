using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_mvc.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
        public string Gender { get; set; }

        public virtual List<Profile> Profiles { get; set; }
        public virtual List<Question> Questions { get; set; }

        public User()
        {
            Profiles = new List<Profile>();
            Questions = new List<Question>();
        }

    }
}