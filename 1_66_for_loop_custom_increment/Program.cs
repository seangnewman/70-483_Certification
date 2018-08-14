using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_66_for_loop_custom_increment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };

            for(int index=0; index < values.Length; index += 2)
            {
                Console.Write(values[index]);
            }

            Console.ReadKey();
        }
    }
}
