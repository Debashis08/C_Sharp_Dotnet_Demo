using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Demo_0012_C_Sharp_Features
{
    //New features in C#
    //1. Improve in out parameters
    //2. Tuples
    //3. Deconstructors

    class OldFeatures
    {
        //Feature 1
        public void GetSum_Product1(int a,int b,ref int c,ref int d)
        {
            c = a + b;
            d = a * b;
        }
        //Feature 2
        public Tuple<int, int> GetSum_Product2(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            Tuple<int, int> t = Tuple.Create(c, d);
            return t;
        }
    }
    //Feature 3
    class Employee
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private int Salary;

        public Employee(int id, string firstName, string lastName, int salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        public void Deconstruct(out int id,out string firstName,out string lastName,out int salary) //This is a Deconstructor. Like Constructors we can also overload the Deconstructors
        {
            id = Id;
            firstName = FirstName;
            lastName = LastName;
            salary = Salary;
        }
    }
    class NewFeatures
    {
        //Feature 1
        public void GetSum_Product1(int a,int b,out int c,out int d)
        {
            c = a + b;
            d= a * b;
        }
        //Feature 2
        public (int Sum, int Product) GetSum_Product2(int a, int b)// we can just name the return variables
        {
            int c = a + b;
            int d = a * b;
            return (c, d);
        }
        //Feature 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            OldFeatures obj1 = new OldFeatures();
            NewFeatures obj2 = new NewFeatures();


            //Demonstrating Feature 1
            Console.WriteLine("Demonstrating Feature 1");
            Console.WriteLine();

            int p = 0, q = 0;
            obj1.GetSum_Product1(4, 5, ref p, ref q);
            Console.WriteLine("The Old feature");
            Console.WriteLine($"sum: {p}");
            Console.WriteLine($"Product: {q}");
            Console.WriteLine();


            Console.WriteLine("The New feature");
            int x, y;
            obj2.GetSum_Product1(4, 6, out x, out y);
            Console.WriteLine($"sum: {x}");
            Console.WriteLine($"Product: {y}");
            Console.WriteLine();


            //Demonstrating Feature 2
            Console.WriteLine("Demonstrating Feature 2");
            Console.WriteLine();
            Tuple<int, int> tObj1 = obj1.GetSum_Product2(2, 3);
            Console.WriteLine("The Old feature");
            Console.WriteLine($"sum: {tObj1.Item1}");
            Console.WriteLine($"Product: {tObj1.Item2}");
            Console.WriteLine();

            //var tObj2= obj2.GetSum_Product(2, 3);           //This is one way to do
            (int sumResult,int productResult) = obj2.GetSum_Product2(3, 4);
            Console.WriteLine("The New feature");
            Console.WriteLine($"sum: {sumResult}");//...and then we can just get that particular value to get
            //Console.WriteLine($"Product: {tObj2.Item2}");//we can still use Item1 and Item2
            Console.WriteLine($"Product: {productResult}");
            Console.WriteLine();

            //Demonstrating Feature 3
            Console.WriteLine("Demonstrating Feature 3");
            Console.WriteLine();

            Employee emp = new Employee(1, "abcd", "efgh", 750000);
            var (id1, fname1, lname1, salary1) = emp;
            Console.WriteLine("Getting all the information of the employee object by using the Deconstructor");
            Console.WriteLine($"The Details of the Employee having ID= {id1} are: ");
            Console.WriteLine($"First Name: {fname1}");
            Console.WriteLine($"Last Name: {lname1}");
            Console.WriteLine($"Salary: {salary1}");
            Console.WriteLine();


            Console.WriteLine("Getting only the First and Last Name using the same Deconstructor without overloading it");
            //Just using an underscore sign in place of that field whose value we do not require
            var (id2, fname2, lname2, _) = emp;
            Console.WriteLine($"The full name of the Employee having ID= {id2} is: {fname2} {lname2}");
            Console.WriteLine();


        }
    }
}
