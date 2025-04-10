using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiseparams
{
    public class A
    {
        public int[] ints;
        public void show(params int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A b=new A();
            a.ints= new int[] { 1, 2, 3 };
            b.ints= new int[] {1, 2, 3 ,4,5};
            a.show(a.ints);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            a.show(b.ints);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            a.show(15, 25, 36, 67, 567, 12);

            Console.Read();

        }
    }
}
