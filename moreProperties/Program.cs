using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace moreProperties
{
    public class Printer
    {
        public void Print()
        {
            int needed = pagecount();

            if (availpages < needed)
            {
                Console.WriteLine("Not enough pages");
                Console.WriteLine($"Please add pages. Current pages = {availpages}");
            }
            else
            {
                availpages -= needed;
                Console.WriteLine("Printing successful.");
                Console.WriteLine($"Pages used: {needed}");
                Console.WriteLine($"Pages remaining: {availpages}");
            }
        }

        public string pageSize { get; set; } = "A4";
        public static int totalpages {  private get; set; }
        public static bool alternate {  get; set; }
        public int pagecount()
        {
            if (alternate)
            {
                return totalpages / 2;

            }
            return totalpages;
        }
        public bool colored {  get; set; }
        int availpages = 1024;
        int pages
        {
            get { return availpages; }
            set
            {
                if ((availpages-pagecount()) < 0)
                {
                    Console.WriteLine("Not enough pages");
                    Console.WriteLine($"Please add pages. Current pages= {availpages}");
                    return;
                }
                else
                {
                    availpages-=pagecount();
                    return;
                }
            }
        }
    }

    static class A
    {
        public static string Name { get; private set; } = "Nishant";
        public static void Output()
        {
            Console.WriteLine(Name);
        }

        static A()
        {
            Console.WriteLine("This should work.");
        }
    }
    static internal class Program
    {
        static string B { get; set; } = A.Name;
        static Program()
        {
/*            string B=A.Name;*/
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many pages are there in the file to be printed?");
            Printer.totalpages= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Do you want print on both sides?True/false");
            Printer.alternate=Convert.ToBoolean(Console.ReadLine());
            Printer printer = new Printer();
            printer.Print();
            Console.Read();
        }
    }
}
