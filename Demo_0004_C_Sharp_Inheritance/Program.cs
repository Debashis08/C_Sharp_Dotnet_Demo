using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_0004_C_Sharp_Inheritance
{
    class Person
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private int Age;

        public Person(int id, string fname, string lname, int age)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
        }
        public void OverloadedMethod()
        {
            Console.WriteLine($"Inside the Person class");
        }

    }
    class Student : Person
    {
        private string Stream;
        private double AverageMarks;
        public Student(int id, string fname, string lname, int age, string stream, double avgmarks) : base(id, fname, lname, age)
        {
            this.Stream = stream;
            this.AverageMarks = avgmarks;
        }
        public new void OverloadedMethod()
        {
            Console.WriteLine($"Inside the Student class");
        }
        public string GetStream
        {
            get
            {
                return Stream;
            }
            set
            {
                Stream = value;
            }
        }
        public double GetAverageMarks
        {
            get
            {
                return AverageMarks;
            }
            set
            {
                AverageMarks = value;
            }
        }
    }
    class Employee : Person
    {
        private string Designation;
        private double Salary;

        public Employee(int id, string fname, string lname, int age, string designation, double salary) : base(id, fname, lname, age)
        {
            this.Designation = designation;
            this.Salary = salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(2, "a", "b", 24);
            p1.OverloadedMethod();
            Console.WriteLine();

            Student p2 = new Student(1, "d", "n", 23, "engg", 9.44);
            p2.OverloadedMethod();
            Console.WriteLine(p2.GetStream);
            Console.WriteLine();

            Person p3 = new Student(3, "c", "d", 24, "engg", 9.34); //Casting
            //p3.GetStream;         //Here this GetStream property can not be called as the object p3 is of base class Person type
            p3.OverloadedMethod();

            Console.WriteLine();

        }
    }
}
