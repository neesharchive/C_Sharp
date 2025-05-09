using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsRe
{
    public class P
    {
        public string name { get; set; }
        public int age { get; set; }
        public int id { get; set; }
    }
    public class S : P
    {
        public void show()
        {
            Console.WriteLine($"{this.id}: {this.name} : {this.age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<P> list = new List<P>()
            {
                new P(){id=2, age=22,name="N"},
                new P(){id=3,age=21, name="Ni"},
                new S(){id=4,age=22,name="Nis"}
        };
            S s = new S()
            {
                id = 5,
                name = "Nishant",
                age = 21
            };
            //s.show();
            
            Console.WriteLine(s.GetType());
            Console.WriteLine(s.GetHashCode());
            list.Add(s);
            list.Insert(0, s);
            list.Remove(s);
            list.RemoveRange(0, 5);
            list.Clear();
            list.AddRange(list);
            
            foreach(P p in list)
            {
                Console.WriteLine($"{p.id}: {p.name}, {p.age}: {typeof(P)}");

            }
            Console.Read();
            
        }
    }
}
