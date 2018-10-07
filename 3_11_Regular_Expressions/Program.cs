using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_11_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var manuallyValidated = ValidateZipCodeManually("1234 AB");
            var regexValidated = ValidateZipCodeRegEx("1001 AB");

            Console.WriteLine($"Were the zip codes manually validated {manuallyValidated}?" +
                $"\nWere the zip codes validated via Regex {regexValidated}");
            CollapseMultipleSpaces();
        }

        public static bool ValidateZipCodeManually(string zipCode)
        {
            // valid zipcodes 1234AB | 1234 AB | 1001 AB
            if(zipCode.Length < 6)
            {
                return false;
            }

            string numberPart = zipCode.Substring(0, 4);
            int number;
            if(int.TryParse(numberPart, out number))
            {
                return false;
            }

            string characterPart = zipCode.Substring(4);

            if (numberPart.StartsWith("0"))
            {
                return false;
            }

            if(characterPart.Trim().Length < 2)
            {
                return false;
            }

            if(characterPart.Length == 3 && characterPart.Trim().Length != 2)
            {
                return false;
            }

            return true;
        }

        static bool ValidateZipCodeRegEx(string zipCode)
        {
            Match match = Regex.Match(zipCode,
                            @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$",
                            RegexOptions.IgnoreCase);
            return match.Success;
        }

        static void CollapseMultipleSpaces()
        {
            RegexOptions options = RegexOptions.None;

            Regex regex = new Regex(@"[ ]{2,}", options);

            string input = "1 2 3 4  5";
            string result = regex.Replace(input, " ");

            Console.WriteLine(result);
        }
    }
}
