using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_HasA
{
    class A
    {
        public int y1;
    }
    class B
    {
        A R;
        public int y2;

    }
    internal class Program
    {
        static int? first()
        {
            return null;
        }
        static void Main(string[] args)
        {
            A a = new A();
            a.y1 = 12;

            Console.Read();
        }
    }
}
