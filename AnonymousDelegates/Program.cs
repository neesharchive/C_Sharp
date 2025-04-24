using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegates
{
    public delegate void del();
    public class A
    {
        public static void show()
        {
            Console.WriteLine("For A");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            del d1 = new del(A.show);

            del d2 = delegate ()
            {
                Console.WriteLine("hello");
                A.show();
            };
            int counter=0;
            del count = delegate
            {
                counter++;
                Console.WriteLine($"Current count is: {counter}");
            };

            count();
            count();
            count();
            count();
            count();
            count();



            Console.Read();
            

        }
    }
}
