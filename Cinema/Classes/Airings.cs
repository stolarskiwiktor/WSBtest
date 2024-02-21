using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    public class Airings
    {
        public DateTime time { get; set; }
        public List<string> rows { get; set; }
        public int numberOfSeat { get; set; }
        public List<Seat> seats { get; set; }

        public Airings(DateTime time)
        {
            this.time = time;
            rows = new List<string> {"A","B","C","D","E","F","G","H","I"};
            numberOfSeat = 10;
            seats = new List<Seat>();
            for (int i = 0; i < rows.Count; i++)
            {
                for(int j = 1; j <= numberOfSeat; j++)
                {
                    Seat new_seat = new Seat(rows[i], j);
                    seats.Add(new_seat);
                }
            }
        }

    }
}
