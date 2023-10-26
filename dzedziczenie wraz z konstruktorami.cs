using System;

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
            Color = color;
        }

        public new void Show() 
        {
            base.Show();
            Console.WriteLine($"kolor: {Color}");
        }
    }
}
