using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_61_Complex_If_Statement
{
   
    class Program
    {
        private static void Check(char input)
        {
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'e')
            {
                Console.WriteLine("{0} is a vowel", input);
            }
            else
            {
                Console.WriteLine("{0} is a consonant", input);
            }
        }
        static void Main(string[] args)
        {

            Check('e');
            Check('t');

            Console.ReadKey();
        }
    }
}
