using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadOnly_Const_Static
{// 1. Create a Circle class with readonly 'pi', const sides, static counter and static method.
    public class Circle
    {
        public static readonly float pi = 3.14f;
        public const int sides = 4;
        public static int count = 0;
        public static void counter()
        {
            float total = 1;
            while(count<sides)
            {
                count++;
                total *= pi;
            }
            Console.WriteLine(total);
        }
    }
   // 2. Create a utility class TemperatureConverter with static methods to convert
   public static class TemperatureConverter
    {
        public static void CelsiustoFar(float temp)
        {
            float far = (temp * (9 / 5) + 32);
            Console.WriteLine(far);
        }
        public static void FartoCelsius(float temp)
        {
            float cel = (temp - 32) / (9 / 5);
            Console.WriteLine(cel);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Circle.counter();


            TemperatureConverter.CelsiustoFar(33.6f);
            TemperatureConverter.FartoCelsius(79.6f);
            Console.Read();
        }
    }
}
