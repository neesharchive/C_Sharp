using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
/*TOPICS(31/03/2025): */


/*pass by reference*/
namespace Strings
/*strings*/
{
    internal class Strings
    {   

        static void output(out int s, int d)
        {
            s = d;

        }
        static void getline(params int[] s)
        {
            foreach(int i in s)
            {
                Console.WriteLine(i);
            }
        }
        static void getline(params string[] s)
        {
            foreach(string i in s)
            {
                Console.WriteLine(i);
            }
        }
        
        static void StringJoin(params string[] s)
        {
            string sent = "";
            foreach( string i in s)
            {
                sent+=$"{i} ";
            }
            Console.WriteLine(sent);
        }
        static void update(ref string s)
        {
            StringJoin(s,"hello","my","friend");
        }
        static void playwithref(ref int[] a)
        {
            int count = 0;
            int newer= 0;
            for(int i=0; i<a.Length;i++)
            {
                count += a[i];
                a[i] *= 2;
                newer += a[i];
            }
            Console.WriteLine($"Total count before= {count}, and after= {newer}");
        }
/*params*/
        static void Main(string[] args)
        {
            
            string s1 = "First";
            string s2 = $"after {s1}";
            String string1 = s2;
            Console.WriteLine(s1.ToLower());

/*verbatium strings*/
            string s3 = @"

                        but this is a {s1}, a verbatium string
                        which does not care 
                        for your
                        \n special characters.";
            Console.WriteLine(s3);
            getline("nishant","nishan","nish");

            StringJoin("nishant", "nishan", "nish");


            /*ref keyword*/
            int[] a = {1, 2, 3, 4};
            
            update(ref s1);
            getline(a);
            playwithref(ref a);
            getline(a);

            /*String Builder and its methods*/
            StringBuilder NString = new StringBuilder("Hello World!");
            NString.Append("this\n");
            NString.AppendLine(NString.ToString());
            NString.Replace("H", "Z");
            NString.EnsureCapacity(3);
            NString.Remove(1,3);
            Console.WriteLine(NString);
            string s4 = "Yo";
            StringBuilder n2 = new StringBuilder(s4 + s3);
            Console.WriteLine(n2);


            /*out keyword*/
            int d;
            output(out d, 98);
            Console.WriteLine(d);
            Console.Read();
        }
    }
}
