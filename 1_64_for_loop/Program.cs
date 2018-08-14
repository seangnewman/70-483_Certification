using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_64_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for(int index = 0; index < values.Length; index++)
            {
                Console.WriteLine(values[index]);
            }

            Console.ReadKey();
        }
    }
}
