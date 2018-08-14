using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_56_multiple_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = false;
            bool c = false;

            if (b)
            {
                Console.WriteLine("b is true");
            }
            else if (c)
            {
                Console.WriteLine("c is true");
            }
            else
            {
                Console.WriteLine("b and c are false");
            }

            Console.ReadKey();
        }
    }
}
