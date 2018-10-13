using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_Access_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            var newDirectory = @"c:\temp\TestDirectory";
            DirectoryInfo directoryInfo = new DirectoryInfo(newDirectory);
            directoryInfo.Create();

            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(
                new FileSystemAccessRule("everyone", FileSystemRights.ReadAndExecute,
                AccessControlType.Allow));
            directoryInfo.SetAccessControl(directorySecurity);

        }
    }
}
