using System;
using System.IO;

namespace _4_1_Drive_Information
{
    class Program
    {
        

        static void Main(string[] args)
        {
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();

            foreach (var driveInfo in drivesInfo)
            {
                Console.WriteLine(" Volume label : {0}", driveInfo.VolumeLabel);
                Console.WriteLine(" File System : {0}",driveInfo.DriveFormat);

                Console.WriteLine(" Available space to current user : {0, 15} bytes", driveInfo.AvailableFreeSpace );
                Console.WriteLine(" Total Available space : {0,15} bytes", driveInfo.TotalFreeSpace);
                Console.WriteLine(" Total Size of drive : {0,15}", driveInfo.TotalSize);
            }

            
        }
    }
}
