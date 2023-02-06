

using System;

namespace AnimalExample
{
    class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Habitat { get; set; }
        public string Food { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Habitat: " + Habitat);
            Console.WriteLine("Food: "+ Food);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal
            {
                Name = "Elephant",
                Species = "Wild",
                Habitat = "Forest",
                Food = "Grass"
            };

            animal.DisplayDetails();
            Console.ReadLine();
        }
    }
}