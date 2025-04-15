using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CampusAccessSystem {
    public enum Roles
    {
        Student, 
        Faculty,
        Admin,
        Guest
    }

    public class Person
    {
        public Person()
        {
            Console.WriteLine("Default Parent, Person");
        }
        static int TotalPeople { get; set; }
        const String campus = "DeltaZero";
        public string Name { get; set; }
        public Department dept {  get; set; }
        public Person(int ID, Roles role)
        {
            TotalPeople++;
            Console.WriteLine($"Your Campus ID is {ID}");
        }
        public virtual void EnterCampus()
        {
            Console.WriteLine("A person has entered the campus.");
        }

        public static void Gettotal()
        {
            Console.WriteLine($"Total Count of People on Campus: {TotalPeople}");
        }

    }

    public class Student : Person
    {

        public Student():base()
        {
            Console.WriteLine("Default Child, Student");
        }
        public Student(int ID, int SID) : base(ID, Roles.Student)
        {
            Console.WriteLine($"Studnet ID is: {SID}");
        }
        public Student(int ID, int SID, string Name) : base(ID, Roles.Student)
        {
            this.Name = Name;
            Console.WriteLine($"Student ID: {SID}; Name: {Name}");
        }
        public sealed override void EnterCampus()
        {
            Console.WriteLine("A STUDENT has entered the campus.");
        }

    }
    public enum Department
    {
        IT=101,
        CS=102,
        EE=103
    }
    public class Faculty : Person
    {
        public Faculty() : base()
        {
            Console.WriteLine("Default Child, Faculty");
        }
        public Faculty(int ID, int FID) : base(ID, Roles.Faculty)
        {
            Console.WriteLine($"Faculty ID: {ID} ");
        }
        public Faculty(int ID, int FID, string Name) : base(ID, Roles.Faculty)
        {
            this.Name=Name;
            Console.WriteLine($"Faculty ID: {FID}; Name: {Name}");
        }
        public Faculty(int ID, int FID, string Name, Department Department) : base(ID,Roles.Faculty)
        {
            dept=Department;
            Console.WriteLine($"Faculty ID: {FID}; Name: {Name}; Department: {Department}");
        }
        public sealed override void EnterCampus()
        {
            Console.WriteLine("A FACULTY has entered the campus.");
        }

    }
    public class Admin : Person
    {
        public Admin() : base()
        {
            Console.WriteLine("Default Child, Admin");
        }
        public Admin(int ID, int AID) : base(ID,Roles.Admin)
        {
            Console.WriteLine($"Admin: {AID}");
        }
        public Admin(int ID, int AID, int DID) : base(ID,Roles.Admin)
        {
            dept=((Department)DID);
            Console.Write($"Admin ID: {AID} of Department ID: {dept}");
        }
        public override void EnterCampus()
        {
            Console.WriteLine("A person from ADMIN has entered the campus.");
        }

    }


/*

    Track unique IDs or access levels per person using constructor-initialized values.

🔹 STATIC / CONST / READONLY / DESTRUCTORS

    Use static to:

    Track how many people have been registered.

    Store the campus name.

🔹PROPERTIES

    Create auto-implemented properties for:

    Role

    Entry time

    Add at least one get-only, and one get; private set; property.

    Add a static property that affects all instances.

🔹 ENUMS & NULLABLE

    Use an enum to define person roles or access types.

    Make the enum nullable in a field and use ?? or ??= for fallback logic.

🔹 ARRAYS

    Use a jagged array to simulate daily activity logs for each student.

    Use a 2D array to represent weekly access matrix: rows = days, cols = zones.

    Populate, loop, and print the arrays properly.

🔹 METHOD OVERLOADING & AMBIGUITY

    Create at least two overloads of a method with different parameters.

    Create a situation where null as an argument causes ambiguity.

    Resolve that ambiguity clearly (e.g., with casts or nullable types).

🔹 UPCASTING & DOWNCASTING

    Implement a method that takes the base type and calls a method — test polymorphism.

    Try to downcast back to a derived type to access extra properties/methods.*/
    internal class Program
    {
        
        
        static Program()
        {
            Console.WriteLine("Welcome to the Registration");
        }
        ~Program()
        {
            Console.WriteLine("Bye bye");
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            Faculty faculty = new Faculty();
            Admin A = new Admin();
            Console.Read();
            
        }
    }
}
