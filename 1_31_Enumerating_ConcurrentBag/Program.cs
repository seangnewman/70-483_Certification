using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _1_28_BlockingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
        
            Task.Run(() => {
                bag.Add(42);
                bag.Add(77);
                Thread.Sleep(1000);
                bag.Add(21);  // Will not display as it was added after iterating over bag

            });

            Task.Run(() =>
            {
                foreach (int i in bag)
                {
                    Console.WriteLine(i);
                }

            }).Wait();

            Console.ReadKey();

        }
    }
}
