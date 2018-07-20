using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_27_AggregateException
{
    class Program
    {
        public static object e { get; private set; }

        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel()
                    .Where(i => IsEven(i));
                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine("There were {0} exceptions", e.InnerExceptions.Count);
            }

            Console.ReadKey();
        }

        public static bool IsEven(int i)
        {
            if( i % 10 == 0)
            {
                throw new ArgumentException("i");
                
            }
            return i % 2 == 0;
        }
    }
}
