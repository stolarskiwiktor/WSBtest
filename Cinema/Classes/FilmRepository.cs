using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    internal class FilmRepository
    {
        private List<Film> filmList { get; set; }

        public FilmRepository()
        {
            filmList = new List<Film>();
            CreateRepository();
        }

        public void CreateRepository()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "film_repository.json");
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    filmList = JsonSerializer.Deserialize<List<Film>>(json);
                }
                else
                {
                    Film film1 = new Film("Aquaman i Zaginione Królestwo", "Jeden król poprowadzi wszystkich. AQUAMAN I ZAGINIONE KRÓLESTWO w kinach od 21 grudnia", new List<string> { "Akcja" }, 2023, 0, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Aquaman.jpg"), new List<Airings>
                    {
                        new Airings(new DateTime(2024, 1, 24, 15, 30, 0)),
                        new Airings(new DateTime(2024, 1, 25, 18, 0, 0)),
                        new Airings(new DateTime(2024, 1, 26, 20, 45, 0)),
                        new Airings(new DateTime(2024, 1, 27, 14, 15, 0))
                    });
                    Film film2 = new Film("Akademia Pana Kleksa", "Akademia Pana Kleksa to uwspółcześniona wersja klasycznej bajki Brzechwy", new List<string> { "Fantasy" }, 2023, 0, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Akademia.jpg"), new List<Airings>
                    {
                        new Airings(new DateTime(2024, 1, 24, 12, 35, 0)),
                        new Airings(new DateTime(2024, 1, 25, 15, 10, 0)),
                        new Airings(new DateTime(2024, 1, 26, 17, 45, 0)),
                        new Airings(new DateTime(2024, 1, 27, 20, 30, 0))
                    });
                    Film film3 = new Film("Napoleon", "Napoleon to przepełniony widowiskową akcją epicki obraz, który szczegółowo opisuje wzlot i upadek kultowego francuskiego cesarza Napoleona Bonaparte", new List<string> { "Dramat" }, 2023, 0, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Napoleon.jpg"), new List<Airings>
                                        {
                        new Airings(new DateTime(2024, 1, 28, 12, 35, 0)),
                        new Airings(new DateTime(2024, 1, 29, 15, 10, 0)),
                        new Airings(new DateTime(2024, 1, 30, 17, 45, 0)),
                        new Airings(new DateTime(2024, 1, 31, 20, 30, 0))
                    });
                    Film film4 = new Film("Wonka", "Wonka to film, którego inspiracją jest niezwykły bohater Charliego i fabryki czekolady, najbardziej znanej książki dla dzieci autorstwa Roalda Dahla", new List<string> { "Fantasy", "Przygoda", "Komedia", "Musical" }, 2023, 0, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Wonka.jpg"), new List<Airings>
                                        {
                        new Airings(new DateTime(2024, 1, 27, 13, 35, 0)),
                        new Airings(new DateTime(2024, 1, 28, 16, 10, 0)),
                        new Airings(new DateTime(2024, 1, 29, 14, 45, 0)),
                        new Airings(new DateTime(2024, 1, 30, 21, 30, 0))
                    });
                    filmList.Add(film1);
                    filmList.Add(film2);
                    filmList.Add(film3);
                    filmList.Add(film4);

                    SaveToFile(filePath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Wystąpił błąd podczas wczytywania danych: {ex.Message}");
            }

        }

        public void SaveToFile(string filePath)
        {
            try
            {
                string json = JsonSerializer.Serialize(filmList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception($"Wystąpił błąd podczas zapisywania danych: {ex.Message}");
            }
        }

        public void AddFilm(Film newFilm)
        {
            filmList.Add(newFilm);
            SaveToFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "baza_filmow.json"));
        }

        public List<Film> GetFilmList()
        {
            return filmList;
        }
    }
}
