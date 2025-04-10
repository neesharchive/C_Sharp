using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac2
{
    internal class Program
    {

        public class first
        {
            public virtual void show()
            {
                Console.WriteLine("First");
            }
        }
        public class second:first {
            public override void show()
            {
                Console.WriteLine("Second");
            }
        }
        public class third:second
        {
            public new void show()
            {
                Console.WriteLine("Third");
            }
        }
        public class fourth:third
        {
            public new void show()
            {
                Console.WriteLine("Fourth");
            }
        }
 /*       public class A
        {
            public int x;
            public void print(ref A a, ref A b)
            {
                a.x *= 4;
                b.x *= 8;
*//*                Console.WriteLine($"Print the number {a.x}");
                Console.WriteLine($"Print the number {b.x}");*//*
            }
            public void show(int z, ref A a,out int y)
            {
                a.x = a.x * z;
                y = a.x;
            }
        }*/
        static void Main(string[] args)
        {
            /*            A a = new A();
                        a.x = 1;
                        A b = new A();
                        b.x = 2;
                        int d;
                        a.show(2,ref a, out d);
                        Console.WriteLine(d);

                        A c=new A();


                        c.print(ref a, ref b);
                        Console.WriteLine(a.x);
                        Console.WriteLine(b.x);*/


            first first;
            first=new first();
            first.show();
            first=new second();
            first.show();
            first=new third();
            first.show();
            first=new fourth();
            first.show();
            Console.Read();
            
        }
    }
}
