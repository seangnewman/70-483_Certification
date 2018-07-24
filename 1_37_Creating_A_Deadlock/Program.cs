﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_37_Creating_A_Deadlock
{
    class Program
    {
        static void Main(string[] args)
        {
            object lockA = new object();
            object lockB = new object();

            var up = Task.Run(()=> {
                lock (lockA)
                {
                    Thread.Sleep(100000);
                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            lock (lockB)
            {
                lock (lockA)
                {
                    Console.WriteLine("Locked B and A");
                }
            }
            up.Wait();

            Console.ReadKey();
               
        }
    }
}
