using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_17_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"c:\temp\test.dat";

            using (StreamReader streamReader = File.OpenText(path)) 
            {
                Console.WriteLine(streamReader.ReadLine());
            }
        }
    }
}
