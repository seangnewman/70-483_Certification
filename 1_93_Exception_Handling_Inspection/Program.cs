using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_93_Exception_Handling_Inspection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = ReadAndParse();
                Console.WriteLine("Parsed {0}", i);
            }
            catch (FormatException e)
            {

                Console.WriteLine("\nMessage: {0}", e.Message);
                Console.WriteLine("\nStackTrace; {0}", e.StackTrace);
                Console.WriteLine("\nHelpLink: {0}", e.HelpLink);
                Console.WriteLine("\nInner Exception: {0}", e.InnerException);
                Console.WriteLine("\nTargetSite: {0}", e.TargetSite);
                Console.WriteLine("\nSource: {0}", e.Source);
            }    
        }

        private static int ReadAndParse()
        {
            string s = Console.ReadLine();
            int i = int.Parse(s);
            return i;

        }
    }
}
