using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_0014_C_Sharp_File_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Creating a file
            FileInfo fi = new FileInfo(@"D:\Codes\C_Sharp_Dotnet_Demo\Files_For_Demo\Test.txt");
            FileStream fs = fi.Create();
            Console.WriteLine("A new file has been created");
            */

            /*
            //Writing to a file
            Console.WriteLine("Please enter some text: ");
            string input = Console.ReadLine();
            try
            {
                TextWriter tw = new StreamWriter(@"D:\Codes\C_Sharp_Dotnet_Demo\Files_For_Demo\Test.txt");
                tw.Write(input);
                tw.Close();
            }
            catch(IOException exc)
            {
                Console.WriteLine($"Error occured: {exc.Message}");
            }
            */

            
            //Reading from a file
            Console.WriteLine("The contents of the file are: ");
            try
            {
                TextReader tr = new StreamReader(@"D:\Codes\C_Sharp_Dotnet_Demo\Files_For_Demo\Test.txt");
                string line = tr.ReadLine();
                Console.WriteLine(line);
                tr.Close();
            }
            catch (IOException exc)
            {
                Console.WriteLine($"Error occured: {exc.Message}");
            }
            
        }
    }
}
