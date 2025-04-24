using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnonymousTypes
{

    public class A
    {
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; }
        public int ID { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new { id = 1, Name="Nishant", Age=23 };
            Console.WriteLine(a);

            Console.WriteLine(a.Name);
            Console.WriteLine(a.Age);
            

            A a1=new A() { ID = 1, Age = 23 };
            Console.WriteLine(a1);


            var arr = new A[]
            {
                new A() { ID = 2, Name = "N", Age = 23},
                new A() { ID = 3, Name = "Nish", Age = 22},
                new A() { ID = 4, Name = "Nishant", Age = 24}
            };

            Console.WriteLine(arr);
            Console.Read();

        }
    }
}
