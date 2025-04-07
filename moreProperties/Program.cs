using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace moreProperties
{
    public static class A
    {
        public static string Name { get; private set; } = "Nishant";
        public static void Output()
        {
            Console.WriteLine(Name);
        }

        static A()
        {
            Console.WriteLine("This should work.");
        }
    }
    static internal class Program
    {
        static string B { get; set; } = A.Name;
        static Program()
        {
/*            string B=A.Name;*/
        }
        static void Main(string[] args)
        {
            Console.Read();
        }
    }
}
