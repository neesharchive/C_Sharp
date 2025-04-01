using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short num = 100;
            //implicit casting
            int integer = num;
            long bigNum = num;     
            float price = num;
            double largeprice = num;
            Console.WriteLine(bigNum);
            Console.WriteLine(bigNum);
            Console.WriteLine(integer);
            

            //explicit casting
            double num2 = 1543426363234623.612341251345234567833456783;
            float price2 =(float)num2;
            long bigNum2 =(long)num2;
            int integer2=(int)num2;
            Console.WriteLine(num2);
            Console.WriteLine(price2);
            Console.WriteLine(bigNum2);
            Console.WriteLine(integer2);

            string booleans = "true";
            bool check=Convert.ToBoolean(booleans);
            Console.WriteLine(check);

            string n = "123";
            int number = Convert.ToInt32(n);
            Console.WriteLine(number);

            string N=Convert.ToString(number);
            Console.WriteLine(N);

            char c=Convert.ToChar(number);
            Console.WriteLine(c);



            //operators

            // 1. Primary
            int x = 5;
            Console.WriteLine("x++: " + x++);
            Console.WriteLine("x--: " + x--);
            string typeName = typeof(int).ToString();
            Console.WriteLine("typeName: " + typeName);
            int def = default(int);
            Console.WriteLine("default: " + def);

            // 2. Unary
            int a = 3;
            Console.WriteLine("a="+a);
            Console.WriteLine("+a: " + +a);                
            Console.WriteLine("-a: " + -a);                
            Console.WriteLine("!false: " + !false);             
            Console.WriteLine("~5: " + ~5);                 
            Console.WriteLine("++a: " + ++a);                
            Console.WriteLine("--a: " + --a);                
            object o = 10;
            Console.WriteLine("(int)o: " + (int)o);             

            // 3. Multiplicative
            Console.WriteLine("Multiplicative: " + (3 * 4));  
            Console.WriteLine("Multiplicative: " + (10 / 2));  
            Console.WriteLine("Multiplicative: " + (10 % 3));  

            // 4. Additive
            Console.WriteLine("Additive: " + (2 + 3));         
            Console.WriteLine("Additive: " + (7 - 4));         

            // 5. Shift
            Console.WriteLine("Shift: " + (1 << 2));           
            Console.WriteLine("Shift: " + (8 >> 2));           

            // 6. Relational
            Console.WriteLine("Relational(5 < 10): " + (5 < 10));     
            Console.WriteLine("Relational(5 > 1): " + (5 > 1));       
            Console.WriteLine("Relational(5 <= 5): " + (5 <= 5));      
            Console.WriteLine("Relational(5 >= 6): " + (5 >= 6));      
            Console.WriteLine("Relational(o is int): " + (o is int));    
            Console.WriteLine("Relational(o as string): " + (o as string));

            // 7. Equality
            Console.WriteLine("Equality(5 == 5): " + (5 == 5));      
            Console.WriteLine("Equality(5 != 6): " + (5 != 6));        

            // 8. Logical AND
            Console.WriteLine("Logical AND(5 & 3): " + (5 & 3));      

            // 9. Logical XOR
            Console.WriteLine("Logical XOR(5 ^ 3): " + (5 ^ 3));      

            // 10. Logical OR
            Console.WriteLine("Logical OR(5 | 3): " + (5 | 3));      

            // 11. Conditional AND
            Console.WriteLine("Conditional AND(true && false): " + (true && false)); // &&

            // 12. Conditional OR
            Console.WriteLine("Conditional OR(true || false): " + (true || false));  // ||

            // 13. Null Coalescing
            string name = null;
            string result = name ?? "default name";
            Console.WriteLine("Null Coalescing: " + result);

            // 14. Ternary
            int age = 20;
            string msg = (age >= 18) ? "Adult" : "Minor";
            Console.WriteLine("Ternary: " + msg);

            // 15. Assignment
            int z = 10;
            Console.WriteLine("z=" + z);
            z += 5;
            Console.WriteLine("Assignment(z += 5): " + z);
            z -= 2;
            Console.WriteLine("Assignment(z -= 2): " + z);
            z *= 2;
            Console.WriteLine("Assignment(z *= 2): " + z);
            z /= 3;
            Console.WriteLine("Assignment(z /= 3): " + z);
            z %= 4;
            Console.WriteLine("Assignment(z %= 4): " + z);
            z <<= 1;
            Console.WriteLine("Assignment(z <<= 1): " + z);
            z >>= 1;
            Console.WriteLine("Assignment(z >>= 1): " + z);
            z &= 7;
            Console.WriteLine("Assignment(z &= 7): " + z);
            z ^= 2;
            Console.WriteLine("Assignment(z ^= 2): " + z);
            z |= 1;
            Console.WriteLine("Assignment(z |= 1): " + z);

            Console.Read();

        }
    }
}
