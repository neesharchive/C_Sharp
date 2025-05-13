using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ref_Out_Params_Ambiguity
{// -- ref, out, params, overloading, ambiguity

    public class Calculator
    {
 // 1. Create overloaded method 'CalculateTotal' with (int, int), (params int[]), and (ref/out int).
        public int CalculateTotal(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }
        public int CalculateTotal(params int[] arr)
        {
            int count = 0;
            foreach(int i in arr)
            {
                count += i;
            }
            Console.WriteLine(count);
            return count;
        }
        public int CalculateTotal(ref int[] a, out int b){
            int total=CalculateTotal(a);
            b=total;
            return b;
        }
    }
    public class amb
    {
        public void GetName(string name="Nishant Bhatt") {
            Console.WriteLine($"Hello, my name is {name}");
        }
        public void GetName()
        {
            Console.WriteLine("Hello, my name is Nishant");
        }
    }
    
    internal class Program
    {
 // 3. Build a CLI calculator supporting Add(ref/out), Add(params), Add(int, int).
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.CalculateTotal();//This works because of the constructor with params. 

            calculator.CalculateTotal(1, 2);
            calculator.CalculateTotal(1, 2, 3,4, 5, 6, 7,8, 9);


            amb amb = new amb();
            amb.GetName();//ambiguous case, did not consider params default
            //due to parameterless method being present. 
            Console.Read();

        }
    }
}
