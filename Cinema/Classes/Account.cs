using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        public Account(string username, string password, string name, string surname) 
        { 
            this.username = username;
            this.password = password;
            this.name = name;
            this.surname = surname;
        }
    }
}
