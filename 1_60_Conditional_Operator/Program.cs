using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_60_Conditional_Operator
{
    class Program
    {
        private static int GetValue(bool p)
        {
            return p ? 1 : 0;
        }
        static void Main(string[] args)
        {
             

            Console.WriteLine("The value is {0}", GetValue(true));
            Console.ReadKey();
        }
    }
}
