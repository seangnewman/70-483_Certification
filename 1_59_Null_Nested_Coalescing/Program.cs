using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_59_Null_Nested_Coalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int? z = null;
            int y = x ?? z ?? -1;

            Console.WriteLine("The value of y is {0}", y);
            Console.ReadKey();
        }
    }
}
