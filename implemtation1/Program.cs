using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using adders;
namespace implemtation1
{
    public static class A1
    {
        
        public static void B(this Class1 a)
        {
            Console.WriteLine("The extended one");
        }
    }
    public struct P
    {
        public int x;
        public int y;
        public string Name {  get; set; }
        public int Age { get; set; }
        public void show()
        {
            Class1 class1 = new Class1();
            class1.write();
            class1.B();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            P p = new P();
            p.show();
            p.Name = "My Name";
            p.Age = 21;
            


            Console.Read();
        }
    }
}
