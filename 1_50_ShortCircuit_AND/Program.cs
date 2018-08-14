using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_50_ShortCircuit_AND
{
    class Program
    {
        public static void Process(string input)
        {
            bool result = (input != null) && (input.StartsWith("v"));
            Console.WriteLine(result);
        }
        
        static void Main(string[] args)
        {
            Process("talue");

            Console.ReadKey();
        }
    }
}
