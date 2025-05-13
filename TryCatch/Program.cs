using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public delegate void ThisMethod(int i);
    
    internal class Program
    {
        static void Main(string[] args)
        {
            void T(int num)
            {
                Console.WriteLine(num);
            }
            void U(int num)
            {
                Console.WriteLine(num * 2);
            }

            ThisMethod t= T;
            t += U;

            t(3);
            Console.WriteLine("Please enter first number");
            int a=Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter second Number");
            int b = Convert.ToInt16(Console.ReadLine());

            try
            {
                Console.WriteLine(a / b);
            }
            catch(ArithmeticException Arex)
            {
                Console.WriteLine($"{Arex.Message}");
            }
            catch(Exception Ex) {
                Console.WriteLine("Nope");
            }
            finally
            {
                Console.WriteLine("Try Complete");
            }

            Console.Read();
        }
    }
}
