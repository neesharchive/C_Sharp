using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_Dynamic
{
    enum Gender
    {
        male, female
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var gender1=(Gender?)Gender.male;
            var gender2=Gender.female;
            dynamic a0;
            Console.WriteLine(gender1);
            Console.WriteLine(gender2);
            a0=Console.ReadLine();
            Console.WriteLine(a0);
            Console.Read();
        }
    }
}
