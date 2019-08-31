using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading
{
    class Employee
    {
        //Properties
        string FirstName { get; set; }
        string LastName { get; set; }

        //Fields
        //Constructor
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        //Methods
        public void eat()
        {
            Console.WriteLine("1.");
            Console.WriteLine("");
            var random = new Random();
            var restaurants = new List<string>
            {
                "McDonald's",
                "Olive Garden",
                "Red Lobster",
                "Otaku Ramen",
                "Thai Phooket",
                "Legends"
            };
            int index = random.Next(restaurants.Count);
            Console.WriteLine($"{FirstName} {LastName} is having lunch at {restaurants[index]}.");
            Console.WriteLine("_______________________________________");
        }

        public void eat(string food)
        {
            Console.WriteLine("2.");
            Console.WriteLine("");
            Console.WriteLine($"{FirstName} {LastName} ate {food}.");
            Console.WriteLine("_______________________________________");
        }

        public void eat(List<Employee> companions)
        {
            Console.WriteLine("3.");
            Console.WriteLine("");
            var random = new Random();
            var restaurants = new List<string>
            {
                "McDonald's",
                "Olive Garden",
                "Red Lobster",
                "Otaku Ramen",
                "Thai Phooket",
                "Legends"
            };
            int index = random.Next(restaurants.Count);
            Console.WriteLine($"{FirstName} {LastName} is having lunch at {restaurants[index]}.");

            foreach (Employee companion in companions)
            {
                Console.WriteLine($"{companion.FirstName}");
            }

            Console.WriteLine("_______________________________________");
            Console.WriteLine($"");
        }

        public void eat(string food, List<Employee> companions)
        {
            Console.WriteLine("4.");
            Console.WriteLine("");
            var random = new Random();
            var restaurants = new List<string>
            {
                "McDonald's",
                "Olive Garden",
                "Red Lobster",
                "Otaku Ramen",
                "Thai Phooket",
                "Legends"
            };
            int index = random.Next(restaurants.Count);
            Console.WriteLine($"{FirstName} {LastName} is having {food} at {restaurants[index]}.");

            foreach (Employee companion in companions)
            {
                Console.WriteLine($"{companion.FirstName}");
            }

            Console.WriteLine("_______________________________________");
            Console.WriteLine($"");
        }

    }
}