using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_80_Lambda_Multiple_Statements
{
    class Program
    {
        public delegate int Calculate(int x, int y);

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static void UseDelegate()
        {
            Calculate calc = (x, y) => {
                Console.WriteLine("Adding Numbers");
                return x + y;
            };
            Console.WriteLine(calc(3, 4));

            calc = (x, y) => {
                Console.WriteLine("Multiplying Numbers");
                return x * y;
           };
            Console.WriteLine(calc(3, 4));
        }
        static void Main(string[] args)
        {
            UseDelegate();

            Console.ReadKey();
        }
    }
}
