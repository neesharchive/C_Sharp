using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Const_Static_ReadOnly
{
    class A
    {
        public A() { }
        public A(int x=12) { }
    }

    class B
    {
        public static int[] arr;
        public B()
        {
            if (arr == null)
                arr = new int[] { 10, 20, 30 };  // fallback

            num = add(arr);

        }
        public B(params int[] a)
        {
            arr = a;
        }
        public static int add(params int[] a)
        {
            if (a == null) return 0;
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum+= a[i];
            }
            return sum;
        }

        public readonly int num=add(arr);

        public const int a = 33333;
        public static readonly int Year = 2025;
        public void show()
        {
            Console.WriteLine(a);
        }
    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            B b = new B();
            b.show();
            B b2 = b;
            Console.WriteLine(B.a);
            Console.Read();
        }
    }
}
/*AMBGUITY CONCEPTS*/
/*if we provide default arguments to the constructor 
 this would create ambiguous situation where we would have two constructors
ready to execute, which should never be the case. 
these situations will not give out errors as they are techincally coded 
correctly.*/
