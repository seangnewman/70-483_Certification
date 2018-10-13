using System.IO;

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
