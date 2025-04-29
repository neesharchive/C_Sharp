using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var P1 = new List<Person>()
            {
                new Person() { Age = 21, Name = "Nishant" },
                new Person() { Age = 22, Name = "Bhatt" }
            };
            
            Person person = new Person();
            person.Age = 21;
            person.Name = "N";

            P1.Add(person);
            foreach (Person p in P1)
            {
                Console.WriteLine($"{p.Age}:{p.Name}") ;
            }


            var Stock = new Dictionary<string, int>()
            {
                {"Apple", 450 },
            { "Mango",600},
                {"Papaya", 300 }
            };

            foreach(var p in Stock)
            {
                Console.WriteLine($"{p.Key}: {p.Value}");
            }

            Console.Read();
        }
    }
}
