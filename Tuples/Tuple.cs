using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    public class A
    {
        int x = 12;
        (int, object) ID;
        public A(int a, object o)
        {
            ID.Item1 = a;
            ID.Item2 = o;
        }
        public void show()
        {
            Console.WriteLine(ID.Item1);
            Console.WriteLine(ID.Item2);
        }
    }
    internal class Tuple
    {
        static void Main(string[] args)
        {
            (int, string) list = (23, "Nishant");

            Console.WriteLine($"The name is {list.Item2}, aged {list.Item1} ");
            A a1=new A(list.Item1, list.Item2);
            a1.show();
            A a = new A(101, a1);
            a.show();
            (int A, int B) nums = (90, 45);
            Console.WriteLine($"Here tuple 1: {nums.A}, {nums.B}");
            (int x, int y) n2 = (10, 20);
            Console.WriteLine($"Here tuple 2 :{n2.x},{n2.y} ");
            //deconstruction of tuples
            //these are variable declarations, and tuple is assigned to them
            //respective of the elements in order...
            (int x,int y)=nums;
            Console.WriteLine($"Desconstructed: {x},{y}");

            //now the variables exist already no need too redeclare
            (x, y) = n2;
            Console.WriteLine($"Desconstructed 2: {x},{y}");



            Console.Read();
        }
    }
}
