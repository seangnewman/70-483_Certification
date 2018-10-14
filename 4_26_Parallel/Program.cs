using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace _4_26_Parallel
{
    class Program
    {
        public static async Task ExecuteMultipleRequestParallel()
        {

             
            HttpClient client = new HttpClient();

            

            Task microsoft =  client.GetStringAsync("http://www.microsoft.com");
            Task msdn = client.GetStringAsync("http://msdn.microsoft.com");
            Task blogs = client.GetStringAsync("http://blogs.msdn.com");
            Task newmanuevers = client.GetStringAsync("http://www.newmanuevers.com");

            await Task.WhenAll(microsoft, msdn, blogs, newmanuevers);
            
            
        }

        static void Main(string[] args)
        {
            Stopwatch elapsedTime = new Stopwatch();
            elapsedTime.Start();

            Task sites = ExecuteMultipleRequestParallel();
            elapsedTime.Stop();

            Console.WriteLine($"Elapsed Time running in Parallel {elapsedTime.ElapsedMilliseconds}");
            

        }
    }
}
