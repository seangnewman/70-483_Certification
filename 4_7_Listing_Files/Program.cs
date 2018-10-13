using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_Listing_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"c:\windows";

            foreach (var file in Directory.GetFiles(filePath))
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");

            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
            foreach (var fileInfo in directoryInfo.GetFiles())
            {
                Console.WriteLine(fileInfo.FullName);
            }
        }
    }
}
