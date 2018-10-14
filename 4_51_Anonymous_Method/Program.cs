using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_51_Anonymous_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> MyDelegate = delegate (int x)
             {
                 return x * 2;
             };

            Func<int, int> MyLambda = x => x * 2;


            Console.WriteLine(MyDelegate(21));
            Console.WriteLine(MyLambda(21));
        }
    }
}
