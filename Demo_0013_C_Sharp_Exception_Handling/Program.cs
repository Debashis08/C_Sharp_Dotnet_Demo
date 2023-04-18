using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_0013_C_Sharp_Exception_Handling
{
    class NotValidException:Exception
    {
        public override string Message
        {
            get
            {
                return "Message: The Mobile Number provided is invalid";
            }
        }
    }
    class WrongInputException:Exception
    {
        public override string Message
        {
            get
            {
                return "Message: Wrong Input. Please provide correct Mobile Number.";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Two types of errors could occur in the program
            //      1. Compile time error (Syntax errors)
            //      2. Runtime error(Errors that occurs when the program runs
            //              (Wrong implementation of logic, Wrong inputs supplied,  missing reuired resources could be the reasons of runtime error

            Console.WriteLine("Please enter yout phone number: ");
            string phoneNumber;
            phoneNumber = Console.ReadLine();
            try
            {
                if (phoneNumber.Length != 10 || phoneNumber[0].ToString()!="9")//<-------we want to check if a modile number starts with 9 and have size of 10 then it could be a valid phone number
                {
                    throw new NotValidException();
                }
                foreach(char s in phoneNumber)
                {
                    if(Char.IsDigit(s)==false)//<---------------if the phone number provided, have anything except digits it will be treated as wrong input
                    {
                        throw new WrongInputException();
                    }
                }
                Console.WriteLine("Message: Phone number is valid.");
            }
            catch (NotValidException exc) 
            { 
                Console.WriteLine(exc.Message);
            }
            catch(WrongInputException exc) 
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                Console.WriteLine("The program terminated");
            }
        }
    }
}
