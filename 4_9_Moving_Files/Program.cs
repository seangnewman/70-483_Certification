using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_9_Moving_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\test.txt";
            string destPath = @"c:\temp\destTest.txt";

            File.CreateText(path).Close();
            File.Move(path, destPath);

            string path2 = @"c:\temp\test2.txt";
            string destPath2 = @"c:\temp\destTest2.txt";

            FileInfo fileInfo = new FileInfo(path2);
            fileInfo.MoveTo(destPath2);
        }
    }
}
