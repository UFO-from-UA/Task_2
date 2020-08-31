using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task.Models
{   // Fake DB model
    public class User
    {
        private static int id = 0;
        //Fake ID
        public int Id_User { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public User()        {        }

        public User(string nick,string email)
        {
            Id_User = id++;
            UserName = nick;
            Email = email;            
        }
    }
}