using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_16_Opening_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\test.dat";

            using (FileStream fileStream = File.OpenRead(path))
            {
                byte[] data = new byte[fileStream.Length];

                for (int index = 0; index < fileStream.Length; index++)
                {
                    data[index] = (byte)fileStream.ReadByte();

                }
                Console.WriteLine(Encoding.UTF8.GetString(data));
            }
            


        }
    }
}
