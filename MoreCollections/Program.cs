using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MoreCollections
{
    public class A
    {
        public static void swap<T>(ref T a, ref T b)
        {
            Console.WriteLine($"Before: {a}, {b}");
            T temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After: {a}, {b}");

            Console.WriteLine("Swap successfull");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Dict1= new Dictionary<int, string>();
            Dict1.Add(1, "N");
            Dict1.Add(2, "B");

            Stack<string> Stack1= new Stack<string>();
            Stack1.Push("url1");
            Stack1.Push("url2");
            Stack1.Push("url3");

            Console.WriteLine(Stack1.Pop());

            int a = 12;
            int b = 15;

            string n = "N";
            string B= "B";

            A.swap(ref a, ref b);
            A.swap(ref n, ref B);
            
            Console.WriteLine(Dict1[1]);
            Console.WriteLine(Dict1[2]);
            Console.Read();

        }
    }
}
