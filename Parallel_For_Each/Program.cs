using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Parallel_For_Each
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i => {
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);

            Parallel.ForEach(numbers, i =>
           {
               Thread.Sleep(1000);
           });

            Console.ReadKey();
        }

       

    }
}
