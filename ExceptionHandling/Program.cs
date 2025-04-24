using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class A
    {
        public void show(int x, int y)
        {
            int s;
            try
            {
                s = x / y;
                Console.WriteLine(s);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This was how it was executed");
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.show(2, 1);
            a.show(1, 0);
            Console.Read();
        }
    }
}
