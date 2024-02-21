using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    internal class Administrator : Account
    {
        public Administrator(string username, string password, string name, string surname) : base(username, password, name, surname)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.surname = surname;

        }
    }
}
