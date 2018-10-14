using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_55_LINQ_Select
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 5, 8, 11 };

            var results = data.Select(d => d);

             
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
