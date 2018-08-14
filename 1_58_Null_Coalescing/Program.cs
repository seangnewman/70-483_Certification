using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_58_Null_Coalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int y = x ?? -1;

            Console.WriteLine("The value of y is {0}", y);
            Console.ReadKey();

        }
    }
}
