using System;
namespace Animals;
class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog
        {
            Name = "Rosy",
            Habitat = "Home",
            EatingHabit = "Omnivores"
        };
        dog.DisplayInfo();

        Duck duck = new Duck
        {
            Name = "Quack",
            Habitat = "Farm",
            EatingHabit = "Herbivores"
        };
        duck.DisplayInfo();
    }
    interface IAnimal
    {
        string Name { get; set; }
        string Habitat { get; set; }
        string EatingHabit { get; set; }
        void DisplayInfo();
    }
    class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }


        public void DisplayInfo()
        {
            Console.WriteLine("Dog Details");
            Console.WriteLine("  Name: " + Name + "  Habitat: " + Habitat + "  Eating Habit: " + EatingHabit);
        }
    }
    class Duck : IAnimal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("Duck Details");
            Console.WriteLine("  Name: " + Name + "  Habitat: " + Habitat+ "  Eating Habit: " + EatingHabit);
        }
    }
}