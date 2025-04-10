using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorPrac
{
    public class A
    {
        public int a;
        public int b;
        public A(int a, int b)
        {
            this.a = a; this.b = b;
            
        }
        public void Copy(ref A obj)
        {
            a=obj.a; b=obj.b;

        }
    }
    public class B
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A first=new A(10, 20);
            A second=new A(90, 100);
            second.Copy(ref first);
            Console.WriteLine(first.a);
            Console.WriteLine(first.b);
            Console.WriteLine(second.a);
            Console.WriteLine(second.b);
            String s = "Hello";
            int[] ints = new int[10];

            A a=new A(1,2);
            B b=new B();
            Object[][] objects = new Object[2][];
            objects[0][0] = a; objects[0][1] = b;
            Console.Read();
        }
    }
}
