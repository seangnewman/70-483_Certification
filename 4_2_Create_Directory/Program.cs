using System.IO;

namespace _4_2_Create_Directory
{
    class Program
    {
        static void Main(string[] args)
        {

            var directory = Directory.CreateDirectory(@"c:\temp\programminginCSharp\Directory");
            var directoryInfo = new DirectoryInfo(@"c:\temp\programminginCSharp\DirectoryInfo");
            directoryInfo.Create();
        }
    }
}
