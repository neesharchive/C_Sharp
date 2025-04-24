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
    public partial struct STR
    {
        static int i = 4;
        public partial class AA
        {
            public int x = 1;
        }
    }

}

namespace DelegateSingle
{
    public partial struct STR
    {
        public partial class AA
        {
            public int y = 14;
        }

    }
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
            STR.AA A1= new STR.AA();
            A1.x = 1;
            A1.y = 3;
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
