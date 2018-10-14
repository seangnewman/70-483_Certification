using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4_19_BufferedStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\bufferedStream.txt";

            using (FileStream fileStream = File.Create(path))
              using (BufferedStream bufferedStream = new BufferedStream(fileStream))
                using (StreamWriter streamWriter = new StreamWriter(bufferedStream))
                {
                streamWriter.WriteLine("A Line of Text");
                }
        }
    }
}
