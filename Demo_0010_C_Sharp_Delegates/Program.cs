using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_0010_C_Sharp_Delegates
{
    public delegate void DelegateAdd(int a, int b);//Defining the delegate
    public delegate string DelegateGreet(string name);
    class Adder
    {
        public void AddIntegerValues(int c, int d)
        {
            Console.WriteLine(c + d);
        }
    }
    static class Greet
    {
        public static string GreetwithName(string name)
        {
            return ($"Hello {name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adder a1 = new Adder();

            DelegateAdd d1 = new DelegateAdd(a1.AddIntegerValues); //Instantiating the Delegate

            d1(100, 50);//Calling the Delegate
            d1.Invoke(100, 50);//Calling the Delegate using the Invoke method
            //Both produces the same result

            DelegateGreet d2 = new DelegateGreet(Greet.GreetwithName);
            Console.WriteLine(d2.Invoke("debashis"));

            Action<int, int> actionobj = a1.AddIntegerValues;
            actionobj.Invoke(3, 4);

            Func<string, string> funcobj = Greet.GreetwithName;
            funcobj.Invoke("nandi");


            Func<int, int, int> funcobj2 = (x, y) =>
            {
                return x + y;
            };
            int result = funcobj2.Invoke(4, 5);
            Console.WriteLine(result);
        }
    }
}
