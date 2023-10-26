using System;
using System.Drawing;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Milka", 10, "czarny");
            cat.Show();
        }
    }

    class Animal
    {
        public string Name { get; }
        public int Age { get; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        
    }

    class Cat : Animal
    {
        public string Color { get; }

        public Cat(string name, int age, string color) : base(name, age)
        {
            this.Color = color;
        }
        public void Show()
        {
            Console.WriteLine($"Imię: {Name}, Wiek: {Age},kolor:{Color}");
        }
    }
}
