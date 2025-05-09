using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Practise
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;

    public class SmartSetList<T>
    {
        
        List<T> list;
        public SmartSetList()
        {
            list = new List<T>();
        }
        public void Add(T item)
        {
            if(!list.Contains(item))
            {
                list.Add(item); 
            }
        }
        public void Delete(T item)
        {
            if(list.Contains(item))
            {
                list.Remove(item);
                Console.WriteLine("Item Removed");
            }
            else
            {
                Console.WriteLine("Item not present.");
            }
        }
        public bool Contains(T item)
        {
            foreach (T current in list)
            {
                if (object.Equals(current, item))
                    return true;
            }
            return false;
        }

        public int Count()
        {
            return list.Count;
        }

        public void Clear()
        {
            list.Clear();
        }

        public void PrintAll()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {

            SmartSetList<int> n = new SmartSetList<int>();
            n.Add(1);
            n.Add(2);
            n.Contains(1);
            n.PrintAll();

            Console.Read();
        }
    }
}
