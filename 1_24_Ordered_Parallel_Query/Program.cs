using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_23_Unordered_Parallel_Query
{
    class Program
    {
        static void Main(string[] args)

        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (int i in parallelResult)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
