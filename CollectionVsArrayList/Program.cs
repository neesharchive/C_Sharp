using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionVsArrayList
{
//You're building a basic grading system.
//You have a List<Student> where each student has Name, Score, and HasSubmitted.
//Print only the students who scored more than 60 and submitted the assignment.
//Then sort and display them by descending score.
    public class Student
    {

        public string Name { get; set; }
        public int Score { get; set; }
        public bool HasSubmitted { get; set; } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{Name="N", HasSubmitted=false, Score=45},
                new Student{Name="Nish", HasSubmitted=true, Score=95},
                new Student{Name="Nishant", HasSubmitted=true, Score=85}
            };
            foreach (Student student in students)
            {
                if (student.Score > 60)
                {
                    Console.WriteLine(student.Name);
                }
            }
            var s=from student in students
                  orderby student.Score
                  select student;

            foreach (Student student in s)
            {
                Console.WriteLine(student.Name+student.Score);
            }
            Console.Read();
        }
    }
}
