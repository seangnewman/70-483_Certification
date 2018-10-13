using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_Building_Directory_Tree
{
    class Program
    {
        private static void ListDirectories(DirectoryInfo directoryInfo, 
            string searchPattern,
            int maxLevel,
            int currentLevel)
        {
            if(currentLevel >= maxLevel)
            {
                return;
            }

            string indent = new string('-', currentLevel);

            try
            {
                DirectoryInfo[] subDirectories = directoryInfo.GetDirectories(searchPattern);

                foreach (var subDirectory in subDirectories)
                {
                    Console.WriteLine(indent + subDirectory.Name);
                    ListDirectories(subDirectory, searchPattern, maxLevel, currentLevel + 1);
                }
            }
            catch(UnauthorizedAccessException ex)
            {
                // You do not have access to folder
                Console.WriteLine(indent + " Cannot access : ", directoryInfo.Name);
                return;
            }catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(indent + " Directory {0} does not exist", directoryInfo.Name);
                return;
            }
        }
        static void Main(string[] args)
        {
            var progDir = @"c:\program files";
            // List all directories under program files to a depth of 5
            DirectoryInfo directoryInfo = new DirectoryInfo(progDir);
            ListDirectories(directoryInfo, "*a*", 5, 0);

        }
    }
}
