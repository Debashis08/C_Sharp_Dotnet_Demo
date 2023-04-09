using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_0002_C_Sharp_Methods
{
    class Person
    {
        private int Id;
        private string FirstName;
        private string LastName;

        public int GetId    //This are called Properties
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string GetFirstName //which looks like a field but it is actually a method
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
        public string GetLastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public int Age { get; set; } //This are called Autoproperties which can be initialized implicitly like this
        public Person(int id, string fname, string lname)   //This is a constructor
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
        }
        public void UpdateInfo(string fname)//Here I have declared a method and implemented the body
        {
            this.FirstName = fname;
        }
        public void UpdateInfo(int id, string fname, string lname)//The same method is overloaded
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
        }
        public void UpdateInfo(string fname, string lname = "")//The same method is overloaded again...
        //here optional parameter is used as lname, if the value is provided then the default value of "" is considered
        //optional parameters always comes last in the parameter list
        {
            this.FirstName = fname;
            this.LastName = lname;
        }
        ~Person()                           //This is destructor
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Methods have one specail thing which is called method signature
            //Method signature consists of the
            //  1.Method access modifier
            //  2.Method return type
            //  3.Method parameter list

            Person p = new Person(1, "Ram", "Nath");
            p.Age = 24;
            Console.WriteLine(p.GetId);
            Console.WriteLine(p.GetFirstName);
            Console.WriteLine(p.GetLastName);
            Console.WriteLine(p.Age);

            Console.WriteLine();
            p.UpdateInfo(2, "Ramnath", "Gopichand");
            Console.WriteLine("1. After updating info\n");
            Console.WriteLine(p.GetId);
            Console.WriteLine(p.GetFirstName);
            Console.WriteLine(p.GetLastName);
            Console.WriteLine(p.Age);


            Console.WriteLine();
            p.UpdateInfo("Shambhunath");
            Console.WriteLine("2. After updating info\n");
            Console.WriteLine(p.GetId);
            Console.WriteLine(p.GetFirstName);
            Console.WriteLine(p.GetLastName);
            Console.WriteLine(p.Age);


            Console.WriteLine();
            p.UpdateInfo("Gopinath", "Sharma");
            Console.WriteLine("3. After updating info\n");
            Console.WriteLine(p.GetId);
            Console.WriteLine(p.GetFirstName);
            Console.WriteLine(p.GetLastName);
            Console.WriteLine(p.Age);
        }
    }
}
