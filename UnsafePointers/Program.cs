using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnsafePointers
{
    public class A
    {
        public int x;
        public string y;
        public void show()
        {

        }
    }
    internal class Program
    {
        static unsafe void Main(string[] args)
        {
            A b=new A();
            int x = 12;

            Console.Read();
        }
    }
}
