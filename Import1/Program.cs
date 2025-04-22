using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Interfaceself1;
namespace Import1
{
    public static class newA
    {
        public static void m1(this A a)
        {
            Console.WriteLine("get it");
        }
    }
    public class A :Interfaceself1.A
    {

    }
    internal class Program
    {
        
    static void Main(string[] args) 
        {
            
            A a=new A();
            a.m1();
            a.Describe();
            a.Describe("Nishant");
            Console.WriteLine("Hello: "+a.Name);
            Console.WriteLine("Yello: "+ a.Description);

            Console.Read();
        }
    }
}
