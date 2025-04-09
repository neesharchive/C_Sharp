using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OverRiding_OverHiding
{
    public class A
    {
        int i;
        public virtual void show()
        {
            Console.WriteLine("First");
        }
    }
    public class B:A
    {
        int j;
        public new void show()
        {
            Console.WriteLine("Second");
        }
    }
    public class C:B
    {
        int k;
        public void show()
        {
            Console.WriteLine("Third");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A r;
            A a = new A();
            r = a;
            r.show();
            B b = new B();
            r = b;
            r.show();
            C c = new C();
            r = c;
            r.show();


            Console.Read();

        }
    }
}
