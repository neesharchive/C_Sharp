using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class A
    {
        private static A a;
        private A()
        {
            Console.WriteLine("Privately created A");
        }

        public static A instancer {  
            get{
                if (a == null)
                {
                    a = new A();
                }return a;
            }
            
        }

    }
    class B
    {
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1=A.instancer;
            A a2=A.instancer;

            Console.Read();
        }
    }
}
