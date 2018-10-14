using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_54_LINQ_Select_Query
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 5, 8, 11 };

            //var results = from d in data
            //             where d % 2 != 0
            //             select d;

            var results = data.Where(d => d %2 == 0);


            foreach (var result in results)
            {
                Console.Write($"{result} ");
            }
            Console.WriteLine();
        }
    }
}
