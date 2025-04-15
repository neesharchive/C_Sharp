using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceself1
{
    interface methods
    {
        string Name { get; }
        string Description { get; }
        void Describe();
        void Describe(string Name);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
