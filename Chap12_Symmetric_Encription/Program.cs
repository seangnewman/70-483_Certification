using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12_Symmetric_Encription
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";
            byte[] plainByte = Encoding.ASCII.GetBytes(plainText);
            byte[] plainKey = Encoding.ASCII.GetBytes("cardinals");
            byte[] plainIV = Encoding.ASCII.GetBytes("IV");
            Symmetric newEncoding = new Symmetric();

            // Encode the data

            byte[] encodedByte = newEncoding.EncryptData(plainByte, null, plainKey);
            string encodedText = Encoding.ASCII.GetString(encodedByte);
            


            //Console.WriteLine($"The encoded text is {encodedText}");

            // Decode the data
            byte[] decodedByte = newEncoding.DecryptData(encodedByte, null, plainKey);
            string decodedText = Encoding.ASCII.GetString(decodedByte);
            Console.WriteLine($"The decoded text is {decodedText}");

        }
    }
}
