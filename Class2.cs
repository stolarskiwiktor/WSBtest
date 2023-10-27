using System;

namespace ConsoleApp1
{
    class Adress // The class declaration should not have a variable name (e.g., "adress")
    {
       
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string ApartamentNumber { get; set; }
        public string Kod_pocztowy { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public string PostalAddress // Corrected property name to follow C# naming conventions
        {
            get
            {
                return $"ul.{Street}/{BuildingNumber}/{ApartamentNumber}\n{Kod_pocztowy} {City}\n{Country}";
            }
        }
    }
}
