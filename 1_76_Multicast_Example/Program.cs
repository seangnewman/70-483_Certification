using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_76_Multicast_Example
{
    class Program
    {
        public static void MethodOne()
        {
            Console.WriteLine("Method One");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("Method Two");
        }

        public delegate void Del();

        public static void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();
        }

        static void Main(string[] args)
        {
            Multicast();

            Console.ReadKey();
        }
    }
}
