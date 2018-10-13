using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12_Combine_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"c:\temp";
            string fileName = @"test.dat";

            var fullPath = Path.Combine(folder, fileName);
            Console.WriteLine($"The full path is {fullPath}");
        }
    }
}
