using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_0007_C_Sharp_Interfaces
{
    interface IStudent
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        void GetFullName();
    }
    interface ICoder
    {
        string FavoriteProgrammingLanguage { get; set; }
        string CPLevel { get; set; }

        void GetFullPortfolio();
    }
    class Student : IStudent, ICoder       //A class can implement any number of interfaces
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteProgrammingLanguage { get; set; }
        public string CPLevel { get; set; }
        public void GetFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        public void GetFullPortfolio()
        {
            Console.WriteLine(CPLevel + " " + FavoriteProgrammingLanguage);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.FirstName = "abc";
            s1.LastName = "efg";
            s1.FavoriteProgrammingLanguage = "CPP";
            s1.CPLevel = "Advanced";
            s1.GetFullName();
            Console.WriteLine();
            s1.GetFullPortfolio();
        }
    }
}
