using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _4_25_Multiple_Awaits
{
    class Program
    {
        public static async Task<List<string>> ExecuteMultipleRequests()
        {
            HttpClient client = new HttpClient();

            var sites = new List<string>();

            sites.Add(await client.GetStringAsync("http://www.microsoft.com"));
            sites.Add(await client.GetStringAsync("http://msdn.microsoft.com"));
            sites.Add(await client.GetStringAsync("http://blogs.msdn.com"));
            sites.Add(await client.GetStringAsync("http://www.newmanuevers.com"));

            return sites;
        }
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
             
            stopwatch.Start();

            Task<List<string>> htmlSites = ExecuteMultipleRequests();
            stopwatch.Stop();
            var sites = new ArrayList(htmlSites.Result);

            foreach (var site in sites)
            {
                Console.WriteLine(site);
            }

            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
