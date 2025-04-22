using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Import1;
using areas;
using System.Diagnostics;
namespace Import2
{
    public static class newarea
    {
        public static void calc(this object a)
        {
            Console.WriteLine("Extended areas from Import2");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.X = 123;
            Console.WriteLine(class1.X);
            class1.calc();
            A a=new A();
            a.m1();
            //imported the extented method of the interfaceself1 from import1
            //but will need to reference interfaceself1, no need to import it. 
            // to run the extended method; here, m1
            //otherwise you can directly use inheritance. 
            Console.Read();

        }
    }
}
