using System;
namespace Birds;
class Program 
{
    public static void Main(string[] args)
    {
        Rabbit rabbit = new Rabbit();
        rabbit.flee();

        Hawk hawk = new Hawk();
        hawk.hunt();

        Fish fish = new Fish();
        fish.flee();
        fish.hunt();
    }
    interface IPrey
    {
        void flee();
    }
    interface IPredator
    {
        void hunt();
    }
    class Rabbit : IPrey
    {
        public void flee()
        {
            Console.WriteLine("The Rabbit runs away");
        }
    }
    class Hawk : IPredator
    {
        public void hunt()
        {
            Console.WriteLine("The hawk is searching for food");
        }
    }
    class Fish : IPrey, IPredator
    {
        public void flee()
        {
            Console.WriteLine("The fish swims away");
        }
        public void hunt()
        {
            Console.WriteLine("The fish is searching for smaller fishes");
        }
    }
}