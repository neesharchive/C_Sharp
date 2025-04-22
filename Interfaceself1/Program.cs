using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceself1
{
    public interface methods
    {
        string Name { get; }
        string Description { get; }
        void Describe();
        void Describe(string Name);
    }
    public class B:methods
    {
        void methods.Describe() { Console.WriteLine("explicitely implemented"); }
        void methods.Describe(string Name) {
            Console.WriteLine("Explicitely implemented Name");
        }
        string methods.Name { get; }
        string methods.Description { get; }

    }
    public class A:methods
    {
        public string Name { get; }
        public string Description { get; }
        public void Describe()
        {
            Console.WriteLine("Im the default method from the interface" +
                "implemented in class A");
        }
        public void Describe(string Name)
        {
            Console.WriteLine("Im the argumented method from the interface " +
                "implemented in class A");

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Describe();
            a.Describe("Nishant");
            methods b = new A();
            b.Describe(); 
            b.Describe("Nishant");
            B b2 = new B();
            b = b2;
            b.Describe();
            b.Describe("Hello");
            Console.Read();
            
        }
    }
}
