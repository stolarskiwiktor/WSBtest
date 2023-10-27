using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę kontaktów:");
            int numberOfContacts = int.Parse(Console.ReadLine());
            Osoba[] people = new Osoba[numberOfContacts];

            for (int i = 0; i < numberOfContacts; i++)
            {
                Console.WriteLine($"Podaj imię kontaktu {i + 1}:");
                string firstname = Console.ReadLine();
                Console.WriteLine($"Podaj nazwisko kontaktu {i + 1}:");
                string lastname = Console.ReadLine();

                Adress address = new Adress(); // Tworzymy nowy obiekt Adress

                Console.WriteLine($"Podaj ulicę kontaktu {i + 1}:");
                address.Street = Console.ReadLine();

                Console.WriteLine($"Podaj numer budynku kontaktu {i + 1}:");
                address.BuildingNumber = Console.ReadLine();

                Console.WriteLine($"Podaj numer mieszkania kontaktu {i + 1}:");
                address.ApartamentNumber = Console.ReadLine();

                Console.WriteLine($"Podaj kod pocztowy kontaktu {i + 1}:");
                address.Kod_pocztowy = Console.ReadLine();

                Console.WriteLine($"Podaj miasto kontaktu {i + 1}:");
                address.City = Console.ReadLine();

                Console.WriteLine($"Podaj kraj kontaktu {i + 1}:");
                address.Country = Console.ReadLine();

                // Tworzymy nowy obiekt Osoba z danymi i adresem
                Osoba osoba = new Osoba(firstname, lastname, address);

                // Dodajemy obiekt Osoba do tablicy
                people[i] = osoba;
            }

            // Wyświetlamy dane kontaktów
            for (int i = 0; i < numberOfContacts; i++)
            {
                Console.WriteLine($"Kontakt {i + 1}: {people[i].Firstname} {people[i].Lastname}, {people[i].FullAddress}");
            }
        }
    }
}
