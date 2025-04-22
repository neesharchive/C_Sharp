using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    public class A
    {
        public int i;
        public int j;
        public A(int a, int b)
        {
            i = a; j = b;
        }
        public static A operator -(A a, A b)
        {
            A n= new A(0,0);
            n.i = a.i+b.i; ;
            n.j = a.j + b.j;

            return n;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a=new A(10,20);
            A b=new A(50,20);
            A c=new A(0,0);
            c = a - b;
            Console.WriteLine($"{c.i}");

            Console.Read();
        }
    }
}
