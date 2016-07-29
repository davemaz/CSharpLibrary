using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Student beavis = new Student("Beavis");
            Student butthead = new Student("Butt-head");
            Student daria = new Student("Daria");

            beavis.Gpa = 2.00f;
            butthead.Gpa = 2.01f;
            daria.Gpa = 4.00f;

            List<Student> students = new List<Student>();
            students.Add(beavis);
            students.Add(butthead);
            students.Add(daria);

            Console.WriteLine("Order Added To List:");
            foreach (Student s in students)
            {
                Console.WriteLine(s.ToString());
            }

            students.Sort();

            Console.WriteLine();
            Console.WriteLine("Sorted by GPA (High to Low):");
            foreach (Student s in students)
            {
                Console.WriteLine(s.ToString());
            }

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        string Name { get; set; }

        string IntroduceYourself();
    }

    class Student : IPerson, IComparable<Student>
    {
        public string Name { get; set; }

        public float Gpa { get; set; }

        public Student(string name)
        {
            Name = name;
            Gpa = 0.0f;
        }

        public string IntroduceYourself()
        {
            return $"Hi, my name is {Name} and my GPA is {Gpa:f}.";
        }

        public override string ToString()
        {
            string introduction = IntroduceYourself();
            return introduction;
        }

        public int CompareTo(Student other)
        {
            if(other is Student)
            {
                var student = (Student)other;
                return student.Gpa.CompareTo(this.Gpa);
            }
            else
            {
                throw new ArgumentException("Not a student.");
            }
        }
    }
}
