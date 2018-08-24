using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_94_ArgumentNullException
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();

            Console.WriteLine(OpenaAndParse(filename)); 


            
        }

        private static string OpenaAndParse(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new ArgumentNullException("filename", "Filename is required");
               
            }
            try
            {
                return File.ReadAllText(filename);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("{0} cannot be found!",e.FileName );
                return string.Empty;
            }
                  
            
        }
    }
}
