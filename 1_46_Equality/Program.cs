using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_46_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            int y = 1;
            int z = 42;

            Console.WriteLine( x == y ); //Displays false value
            Console.WriteLine( x == z ); //Displays true value

            Console.ReadKey();

        }
    }
}
