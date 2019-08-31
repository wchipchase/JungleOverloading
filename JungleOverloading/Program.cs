using System;
using System.Collections.Generic;

namespace JungleOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Heading
            Console.WriteLine("Jungle Overloading Assignment:");
            Console.WriteLine("");

            // Employees
            Employee employee1 = new Employee("Wayne", "Chipchase");
            Employee employee2 = new Employee("Amy", "Chipchase");
            Employee employee3 = new Employee("Maggie", "Chipchase");
            Employee employee4 = new Employee("Maria", "Chipchase");

            // Employee List
            // How to explicitly set objects in list without having to use the Add method?
            var companions = new List<Employee>();
            companions.Add(employee1);
            companions.Add(employee2);
            companions.Add(employee3);

            // Methods
            employee1.eat();
            Console.WriteLine("");

            employee2.eat("pizza");
            Console.WriteLine("");

            employee3.eat(companions);
            Console.WriteLine("");

            employee4.eat("steak", companions);
            Console.ReadLine();
        }
    }
}
