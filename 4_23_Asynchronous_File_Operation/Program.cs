using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_23_Asynchronous_File_Operation
{
    class Program
    {
        public static async Task CreateAndWriteAsyncToFile(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create,
                        FileAccess.Write, FileShare.None, 4096, true))
            {
                byte[] data = new byte[1000000];
                new Random().NextBytes(data);

                await stream.WriteAsync(data, 0, data.Length);

            }
        }
        static void Main(string[] args)
        {
            string filePath = @"c:\temp\dataFile.txt";
            Task doSomething = CreateAndWriteAsyncToFile(filePath);

        }
    }
}
