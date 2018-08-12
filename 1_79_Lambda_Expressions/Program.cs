using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_79_Lambda_Expressions
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
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4));

            calc = (x,y) => x * y;
            Console.WriteLine(calc(3, 4));
        }
        static void Main(string[] args)
        {
            UseDelegate();

            Console.ReadKey();
        }
    }
}
