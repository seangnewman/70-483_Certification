﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_18_Compressing_GZipStream
{
    class Program
    {
        static void Main(string[] args)
        {

            string folder = @"c:\temp";
            string uncompressedFilePath = Path.Combine(folder, "uncompressed.dat");
            string compressedFilePath = Path.Combine(folder, "compressed.gz");
            byte[] dataToCompress = Enumerable.Repeat((byte)'a', 1024 * 1024).ToArray();

            using(FileStream uncompressedFileStream = File.Create(uncompressedFilePath))
            {
                uncompressedFileStream.Write(dataToCompress, 0, dataToCompress.Length);
            }

            using (FileStream compressedFileStream = File.Create(compressedFilePath))
              using(GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
            {
                compressionStream.Write(dataToCompress, 0, dataToCompress.Length);
            }

            FileInfo uncompessedFile = new FileInfo(uncompressedFilePath);
            FileInfo compressedFile = new FileInfo(compressedFilePath);

            Console.WriteLine(uncompessedFile.Length);
            Console.WriteLine(compressedFile.Length);
        }

        
    }
}
