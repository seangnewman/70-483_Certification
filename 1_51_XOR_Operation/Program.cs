using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_51_XOR_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine( a ^ a );      //False
            Console.WriteLine( a ^ b );      //True
            Console.WriteLine( b ^ b );     //False

            Console.ReadKey();
        }
    }
}
