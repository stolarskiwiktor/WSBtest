using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    public class User : Account
    {
        public List<Reservation> reservations { get; set; }

        [JsonConstructor]
        public User(string username, string password, string name, string surname, List<Reservation> reservations) : base(username, password, name, surname)
        {
            this.reservations = reservations;
        }

        public User(string username, string password, string name, string surname) : base(username, password, name, surname)
        {
        }
    }
}
