using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENU_Nullable
{
    internal class Program
    {
        enum Gender
        {
            Male, Female
        }
        enum AgeGroup : byte
        {
            Teenager, Adult, Senior
        }

        internal class ENUM_Nullable
        {

            static void Main(string[] args)
            {
                /*enum*/
                Gender gender1 = Gender.Male;
                Console.WriteLine($"First: {gender1}");
                Gender gender2 = Gender.Female;
                Console.WriteLine($"Second: {gender2}");
                Gender gender3 = (Gender)2;
                Console.WriteLine(gender3);
                Gender gender4 = (Gender)1;
                Console.WriteLine(gender4);

                Console.WriteLine("Hello world");




                /*does not work as your typical constructor with input parameters
                 it only creates a new enum object with the default (0) value
                ->It would be a better practise to have 0 defined as null or any
                default value when constructing your enum to tackle any such cases*/
                Gender g = new Gender();
                Console.WriteLine($"Default output using enum Constructor:{g}");

                /*Nullable,nullable collaging, nullable helper*/

                Nullable<Gender> gender = null;
                gender = gender ?? Gender.Male;
                Console.WriteLine($"Final output for gender: {gender}");
                Gender? gender5 = null;
                gender5 = gender5 ?? Gender.Female;
                Console.WriteLine($"Final output for gender5: {gender5}");

                Console.Read();
            }
        }
    }
}
