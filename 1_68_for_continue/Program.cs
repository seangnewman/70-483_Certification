using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_68_for_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };

            for(int index=0; index< values.Length; index++)
            {
                if (values[index] == 4)
                    continue;

                Console.Write(values[index]);
            }
            Console.ReadKey();
        }
    }
}
