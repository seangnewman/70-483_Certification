using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_48_ShortCircuit_OR_Operation
{
    class Program
    {
        public static void OrShorCircuit()
        {
            bool x = true;
            bool result = x || GetY();
        }

        private static bool GetY()
        {
            Console.WriteLine("This method never gets's called");
            return true;
        }
        static void Main(string[] args)
        {
            OrShorCircuit();

            Console.ReadKey();
        }
    }
}
