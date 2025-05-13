using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInterfaceRef
{
    public class A
    {
        public int num{  get; set; }
        public A(int a)
        {
            num = a;
        }
    }
    public class B : A
    {

        public B(int a, int b) : base(a)
        {
            this.num = b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            B b = new B(3, 4);
            Console.WriteLine(b.num);
            A a = new A(6);
            Console.WriteLine(a.num);

            Console.Read();
        }
    }
}
