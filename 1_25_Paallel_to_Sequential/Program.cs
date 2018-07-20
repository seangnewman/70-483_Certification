using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_25_Paallel_to_Sequential
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .AsSequential();


            foreach( int i in parallelResult.Take(10))
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
