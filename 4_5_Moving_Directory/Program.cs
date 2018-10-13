using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_Moving_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            var originDir = @"c:\temp\programminginCSharp";
            var targetDir = @"c:\temp\TestDirectory\TestDirectory";

            Directory.Move(originDir, targetDir);
            DirectoryInfo directoryInfo = new DirectoryInfo(originDir);

            directoryInfo.MoveTo(targetDir);

        }
    }
}
