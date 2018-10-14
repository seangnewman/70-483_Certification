using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_20_FileExists
{
    class Program
    {
        static string doesFileExist(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }

            return string.Empty;
        }

        static void Main(string[] args)
        {
            string dataFile = @"c:\temp\test.dat";

            string returnData = doesFileExist(dataFile);

            if(returnData.Length > 0)
            {
                Console.WriteLine(returnData);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            


        }
    }
}
