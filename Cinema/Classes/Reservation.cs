using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    public class Reservation
    {
        public Seat Seat { get; set; }
        public string Title { get; set; }
        public DateTime Time { get; set; }

        // Parameterless constructor required for deserialization
        public Reservation()
        {
        }

        public Reservation(Seat seat, string title, DateTime time)
        {
            Seat = seat;
            Title = title;
            Time = time;
        }
    }
}
