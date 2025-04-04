using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*method/constructor overloading*/
namespace Overloading
{
    class A
    {
        //constructor overloading
        public void getdetails()
        {
            Console.WriteLine("You need to call constructor with arguments to" +
                " print something specific about you");
        }
        public void getdetails(int age)
        {
            Console.WriteLine($"Your age is {age} years");
        }
        public void getdetails(int age, string name)
        {
            Console.WriteLine($"Hi {name}, your age is {age} years");
        }
    }
    internal class Program
    {
       

        //static method overloading
        public static void method1()
        {
          Console.WriteLine("Hello");
        }
        public static void method1(int x) { Console.WriteLine($"Hello {x}");}
        static void Main(string[] args)
        {
            A a=new A();
            a.getdetails();
            a.getdetails(43);
            a.getdetails(21, "Nishant");
            Console.Read();
        }
    }
}
