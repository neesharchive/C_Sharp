using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class A<T>
    {
        public T Value { get; set; }
        public A(T t)
        {
            Value = t;
            Console.WriteLine(Value);
        }

    }
    public class B
    {
        public int x { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Vadodara");
            cities.Add("Ahmedabad");
            cities.Add("Surat");
            foreach (string i in cities)
            {
                Console.WriteLine(i);
            }
            A<int> a = new A<int>(12);
            A<string> b = new A<string>("Nishant");
            B b1=new B();
            A<B> a2 = new A<B>(b1);
            Console.Read();
        }
    }
}
