using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_71_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };

            foreach( int value in values)
            {
                Console.Write(value);
            }

            Console.ReadKey();
        }
    }
}
