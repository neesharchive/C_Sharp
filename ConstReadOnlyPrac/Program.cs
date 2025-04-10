using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstReadOnlyPrac
{
    public class A
    {
        public const int a = 9999;

        public readonly int b;
        public A(int x)
        {
            b = x;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            A first = new A(12);
            A second = new A(32);
            Console.WriteLine($"Read only: {first.b}");
            Console.WriteLine($"Read only: {second.b}");
            Console.WriteLine($"Const: {A.a}");
            Console.WriteLine($"Const: {A.a}");
            Console.Read();
        }
    }
}
