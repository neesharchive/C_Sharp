using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSingle
{
    partial class B
    {
        static int y=23;
    }
}

namespace DelegateSingle
{

    partial class B
    {
        static int x=12;

        public static void show()
        {
            Console.WriteLine($"Here is it: {x} and {y}");
        }
    }

    public delegate void Del1();

    interface m
    {
        void m1();
        void m2();
    }
    public class A : m
    {
        public void m1()
        {
            Console.WriteLine("Method m1");
        }
        public void m2()
        {
            Console.WriteLine("Method m2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B.show();

            Del1 d1;
            A a1= new A();
            d1 = a1.m1;
            d1();
            d1 = a1.m2;
            d1();

            Console.Read();
        }
    }
}
