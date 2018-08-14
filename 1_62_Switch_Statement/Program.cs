using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_62_Switch_Statement
{
    class Program
    {
        private static void CheckWithSwitch(char input)
        {
            switch (input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    {
                        Console.WriteLine("{0} is a vowel", input);
                        break;
                    }
                case 'y':
                    {
                        Console.WriteLine("{0} is sometimes a vowel", input);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("{0} is a consonant",input);
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            CheckWithSwitch('a');
            CheckWithSwitch('y');
            CheckWithSwitch('s');
            Console.ReadKey();
        }
    }
}
