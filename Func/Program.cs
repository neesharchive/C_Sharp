using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    
    internal class Program
    {
        public static void Operate(int a, int b, Func<int, int, int> f)
        {
            int result=f(a, b);
            Console.WriteLine(result);
        }
        public static string Convert(string s, Func<string, string> c) {
            string result = c(s);
            Console.WriteLine(result);
            return result;
        }

        static void Main(string[] args)
        {
            Program.Operate(3, 4, (int x, int y) => x*x + y*y);
            Program.Operate(25, 64, (x, y) => y%x);

            
            Func<int,int> a = ((x) =>
            {
                x++;
                Console.WriteLine(x);
                return ++x;
            });

            Console.WriteLine(a(98));


            string string1 = Program.Convert("Nishant", (x) => x.ToLower());
            string string2= Program.Convert("Nishant", (x) => x.ToUpper());
            string string3=Convert(string2 + string1, (x)=>"---"+x+"---");
            Console.Read();


        }
    }
}
