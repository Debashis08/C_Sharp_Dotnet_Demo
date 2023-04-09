using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_0008_C_Sharp_Generics
{
    class GenericMethods
    {
        public T AddValues<T>(T a, T b)
        {
            dynamic _a = a;
            dynamic _b = b; ;
            return (_a + _b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericMethods g1 = new GenericMethods();
            int result1 = g1.AddValues<int>(2, 5);
            Console.WriteLine(result1);
            double result2 = g1.AddValues<double>(5.6, 7.9);
            Console.WriteLine(result2);
        }
    }
}
