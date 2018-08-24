using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(s))
                {
                    break;
                }

                try
                {
                    int i = int.Parse(s);
                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("{0) is not a valid number.  Please try again", s);
                }
            }
        }
    }
}
