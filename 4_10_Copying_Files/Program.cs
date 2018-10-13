using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_Copying_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\test.txt";
            string destPath = @"c:\temp\destText.txt";
            string destPath2 = @"c:\temp\destText2.txt";

            File.CreateText(path).Close();
            File.Copy(path, destPath);

            FileInfo fileInfo = new FileInfo(path);
            fileInfo.CopyTo(destPath2);
        }
    }
}
