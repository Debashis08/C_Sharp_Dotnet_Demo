using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_0001_C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo to show basic datatypes and how to take inputs and give outputs
            int ivalue = 10;
            long lvalue = 1500000000L;
            float fvalue = 10.35F;
            double dvalue = 10.90D;
            decimal dcvalue = 10M;
            bool bvalue = true;
            char cvalue = 'A';
            string svalue = "Hello World";


            Console.WriteLine($"The integer value is {ivalue}");
            Console.WriteLine($"The long value is {lvalue}");
            Console.WriteLine($"The float value is {fvalue}");
            Console.WriteLine($"The double value is {dvalue}");
            Console.WriteLine($"The decimal value is {dcvalue}");
            Console.WriteLine($"The boolean value is {bvalue}");
            Console.WriteLine($"The character value is {cvalue}");
            Console.WriteLine($"The string value is {svalue}");

            Console.WriteLine();
            Console.WriteLine("Please enter an integer");
            int num;
            num = int.Parse(Console.ReadLine());//same thing we can perform with long, float, double, decimal and bool
            Console.WriteLine($"The input user provided is {num}");
        }
    }
}
