using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_49_AND_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 42;
            bool result = (0 < value) && (value < 100);

            Console.WriteLine("The result is {0}", result);

            Console.ReadKey();
        }
    }
}
