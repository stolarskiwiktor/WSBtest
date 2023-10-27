using System;

namespace ConsoleApp1
{
    class Osoba
    {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public Adress Address { get; set; }

        public Osoba(string firstname, string lastname, Adress address)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
        }

        public string Introduce()
        {
            return Firstname;
        }

        public void SetData(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string FullAddress
        {
            get
            {
                if (Address != null)
                {
                    return Address.PostalAddress;
                }
                else
                {
                    return "Address not set";
                }
            }
        }
    }
}
