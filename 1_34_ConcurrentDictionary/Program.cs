using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_34_ConcurrentDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new ConcurrentDictionary<string, int>();

            if(dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Line Added");
            }

            if(dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("value 42 updated to 21");
            }

            dict["k1"] = 42;    //overwrite to value of 42 again

            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("k2", 3);

            Console.ReadKey();
        }
    }
}
