using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _4_24_Asynchronous_HTTP_Request
{
    class Program
    {
        public static async Task<string> ReadAsyncHttpRequest()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("http://www.newmanuevers.com");
            return result;
        }

        static void Main(string[] args)
        {
             
            Task<string> htmlText = ReadAsyncHttpRequest();
            Console.WriteLine(htmlText.Result);
        }
    }
}
