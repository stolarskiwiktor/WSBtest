using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    public class Film
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> genre { get; set; }
        public int yearOfProduction { get; set; }
        public int minimalAge { get; set; }
        public string posterPath { get; set; }
        public List<Airings> airings { get; set; }

        public Film(string title, string description, List<string> genre, int yearOfProduction, int minimalAge, string posterPath, List<Airings> airings)
        {
            this.title = title;
            this.description = description;
            this.genre = genre;
            this.yearOfProduction = yearOfProduction;
            this.minimalAge = minimalAge;
            this.posterPath = posterPath;
            this.airings = airings;
        }


    }
}
