using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8_Delete_File
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"c:\temp\test.txt";
            string path2 = @"c:\temp\test2.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            FileInfo fileInfo = new FileInfo(path2);

            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
        }
    }
}
