using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_and_static_const
{/*static constructor, static class, static method, 
  * destructor
  * get, set, properties, static properties, auto implemented property*/

    class A
    {
        public static int NUM {  get; set; }
        static int num;
        static string start = "Welcome to the program.";
        static A()
        {
            NUM = 334;
            Console.WriteLine(A.start);
            Console.WriteLine(NUM);
        }

        public int Name { get; set; }
    }
    internal class Program
    {
        static Program()
        {
            A.NUM = 356;
            Console.WriteLine(A.NUM);
        }
        static void Main(string[] args)
        {
            
            Console.Read();
        }
    }
}
