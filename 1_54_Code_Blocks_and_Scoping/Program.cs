using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_54_Code_Blocks_and_Scoping
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;

            if (b)
            {
                int r = 42;    // produces error outside of block scope
                b = false;
                Console.WriteLine("The values are {0} and {1}", r, b);
            }
            //Console.WriteLine("The values are {0} and {1}", r, b);
            Console.ReadKey();
        }
    }
}
