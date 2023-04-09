using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_0003_C_Sharp_Static_Classes
{
    static class University//Here I have declared the Course class as static so, in the Main method I can not instantiate any object of Course class
    {
        private static int UniversityId;        //<---- All the members of static class must be declared as static
        private static string UniversityName;   //

        static University()//Access modifiers are not allowed on static constructors
        {
            UniversityId = 1;
            UniversityName = "Jadavpur University";
        }
        public static void GetUniversityID()
        {
            Console.WriteLine($"The University Id is {UniversityId}");
        }
        public static void GetUniversityName()
        {
            Console.WriteLine($"The University Name is {UniversityName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //No instance of the static class can be created 

            //Here I have called these two methods using the class name
            University.GetUniversityID();
            University.GetUniversityName();
        }
    }
}
