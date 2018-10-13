using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_Delete_Existing_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists(@"c:\temp\programminginCSharp\Directory")) ;
            {
                Directory.Delete(@"c:\temp\programminginCSharp\Directory");
            }

            var directoryInfo = new DirectoryInfo(@"c:\temp\programminginCSharp\DirectoryInfo");
            if (directoryInfo.Exists)
            {
                directoryInfo.Delete();
            }
        }
    }
}
