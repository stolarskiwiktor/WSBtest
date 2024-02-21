using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    public class Seat
    {
        public bool taken { get; set; }
        public string seat_row { get; set; }
        public int seat_number { get; set; }

        public Seat(string seat_row, int seat_number)
        {
            taken = false;
            this.seat_row = seat_row;
            this.seat_number = seat_number;
        }
    }
}
