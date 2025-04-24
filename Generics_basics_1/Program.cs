using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics_basics_1
{
    public class A
    {
        public static dynamic Add(dynamic a, dynamic b)
        {
            Console.WriteLine(a + b);
            return a+b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A.Add(1, 2);
            //A.Add(true, false);
            A.Add("N", "B");
            Console.Read();
        }
    }
}
