using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_81_Using_Action_Delegate
{
    class Program
    {
        public static Action<int, int> Add = (x, y) =>
        {
            Console.WriteLine("Adding two numbers result = {0}", x + y);
        };

        public static Action<int, int> Multiply = (x, y) =>
        {
            Console.WriteLine("Multiplying  two numbers result = {0}", x * y);
        };



        public static void UseDelegate()
        {
            Add(3, 4);
            Multiply(3, 4);
        }
        static void Main(string[] args)
        {
            //UseDelegate();

            UseDelegate();



            Console.ReadKey();
        }
    }
}
 