using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesMulti
{
    
    internal class Program
    {   
        public delegate void del1();
        public static void m1()
        {
            Console.WriteLine("The method1");
        }
        public static void m2()
        {
            Console.WriteLine("The method2");
        }
        static void Main(string[] args)
        {
            del1 d = new del1(m1);
            d();
            d += m2;
            d+= m1;
            d += m2;
            d += m1;
            d += m2;
            d -= m1;
            d -= m2;
            d -= m1;
            d -= m2;
            d();

            Console.Read();
        }
    }
}
