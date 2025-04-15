using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Indexers
{
    public class A
    {
        public int x = 12;
        string[] names=new string[10];
        int[] grades=new int[10];
        public string this[int a]//indexer 1 for class A
        {
            get
            {
                return $"{names[a]} : {grades[a]}";
            }
            set
            {
                names[a] = value;
            }
        }
        public string this[string b]//overloaded indexer for class A
        {//takes name/string as argument and matches with the names array to return 
            //the name and grades at correcsponding grades using matching index. 
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == b)
                    {
                        return $"{names[i]} : {grades[i]}";
                    }
                }
                return "Not found";
            }
            set
            {//sets the grades(value)
             //at index matching the name passed from the names array
                for (int i = 0;i < names.Length; i++)
                {
                    if (names[i]==b)
                    {
                        grades[i] = Convert.ToInt32(value);
                        return;
                    }
                }
            }
        }

    }

    public class B
    {
        A[] objects = new A[10];//array of A class type of objects
        public A this[A a]//class reference as argument
        {
            get
            {//sees if passed reference and a reference already present
             //refer to the same object.
                foreach(A o in objects)
                {
                    if (o == a)
                    {
                        return o;
                    }
                }
                return null;
            }
            set
            {//sets the reference for the object with the reference passed 
                //if the array has space. 
                for (int i = 0; i < objects.Length; i++)
                {
                    if (objects[i] == null)
                    {
                        objects[i] = a;
                        break;
                    }
                }
            }
        }
    }
    internal class Program
    {
        //18. indexers
        //19. class return type
        //20. Indexer overloading
        static void Main(string[] args)
        {
            A a = new A();
            A a2=new A();
            a2.x = 102;
            a[0]="A";
            a[1]="B";
            a[2]="C";
            a["A"] = "92";
            a["B"] = "83";
            a["C"] = "78";

            B b = new B();
            b[a] = a;
            b[a2] = a2;
            Console.WriteLine(b[a].x);
            Console.WriteLine(b[a2].x);

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            int x = 12;
            object o = x;

            
            Console.WriteLine(o);
            Console.ReadLine();
        }
    }
}
