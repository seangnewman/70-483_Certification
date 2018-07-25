using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_44_Cancelled_Continuation
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(1000);
                }

                throw new OperationCanceledException();
            }, token).ContinueWith((t) =>
            {
                t.Exception.Handle((e) =>
                {
                    return true;
                });
                Console.WriteLine("You have cancelled the task");
            }, TaskContinuationOptions.OnlyOnCanceled);

          


            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();


        }
    }
}
