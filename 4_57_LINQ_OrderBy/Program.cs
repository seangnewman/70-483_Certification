using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_57_LINQ_OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 4, 8, 11 };

            var result = data.Where(d => d > 5)
                .OrderByDescending(d => d);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
