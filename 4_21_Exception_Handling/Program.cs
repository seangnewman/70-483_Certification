using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_21_Exception_Handling
{
    class Program
    {
        static string fileException(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch (DirectoryNotFoundException ex)
            {

            }catch(FileNotFoundException ex)
            {

            }

            return string.Empty;
        }
        static void Main(string[] args)
        {
            //string fileName = @"c:\temp\test.dat";
            string fileName = @"c:\temp\test2.dat";
            string returnData = fileException(fileName);

            if(returnData.Length > 0)
            {
                Console.WriteLine(returnData);
            }
            else
            {
                Console.WriteLine("file does not exist");
            }
        }
    }
}
