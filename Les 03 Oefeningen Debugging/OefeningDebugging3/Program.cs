using System;
using System.Collections.Generic;

namespace OefeningDebugging3
{
    class Program
    {
        static void Main(string[] args)
        {
            // List van Persons aanmaken met 2 instanties in 
            var persons = new List<Person> { 
                new Person { Name = "Jan" }, 
                new Person { Name = "Dimitri" } 
            };
            // De namen tonen
            foreach(var person in persons)
            {
                Console.WriteLine(person.Name);
            }
            Console.ReadLine();
        }
    }
}
