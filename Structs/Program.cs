using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    interface availability
    {
        void getSeats(int seats);
    }
    public struct Ticket:availability
    {
        public void getSeats(int x)
        {
            
        }
        public int id;
        public string name;
        public int Id { get; set; }
        public string Type { get; set; }
        public Travel travel { get; set; }

    }
    public class Travel
    {
        public int x=12;
        public int y;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket();
            Ticket ticket2;
            ticket2.name = "Nishant";
            ticket2.id = 1123;
            ticket.travel = new Travel();
            Console.WriteLine(ticket.travel.y);
            Console.WriteLine(ticket.travel.x);
            //It is important to note that methods in struct work on the 
            //'this' keyword, and hence, we can only assignment value type variables
            //without calling the constructor. 
            Console.Read();

        }
    }
}
