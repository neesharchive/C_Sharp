using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace areas
{
    sealed public class Class1
    {
        public int X { get; set; }
        public void show(int num)
        {
            Console.WriteLine($"The area of square is: {num * num}");
        }
        
    }
}
