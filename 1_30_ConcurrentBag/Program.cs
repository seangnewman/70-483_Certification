using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_28_BlockingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            bag.Add(42);
            bag.Add(21);

            int result;
            if(bag.TryTake(out result))
                Console.WriteLine(result);
            if(bag.TryPeek(out result))
                Console.WriteLine("There is a next item : {0}", result);

            Console.ReadKey();

        }
    }
}
