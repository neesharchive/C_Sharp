using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Random
{

    public class A
    {
        static int Num= 12;
        public string Name{ get; set; }
        public int age = 18;
        public A()
        {
            Console.WriteLine("Default Constructor");
        }
        public A(int x)
        {
            Console.WriteLine($"Constructor passing the value {x}");
        }
        public virtual void show()
        {
            Console.WriteLine("THis is the method from the parent class");
        }
    }
    public class B : A
    {
        public int z { get; set; }
        public B() :base()
        {
            Console.WriteLine("Callling the default constructor of the parent class");
        }
        public B(int x, int y) : base(x)
        {
            z= y;
        }
        public override void show() {
            Console.WriteLine("This is from the B class");
        }
    }

    public class C
    {
        A a;
        
        public C(int x,A a)
        {
            this.a = a;
            x = a.age;
            Console.WriteLine($"Class C's object running A's object {x}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            /*            A a = new A();
                        B b = new B(2,3);
                        C c = new C(3,a);*/
            A a;
            a = new A();
            a.show();
            a = new B();
            a.show();
            

            Console.Read();
        }
    }
}












//base default argument, jagged array