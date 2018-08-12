﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_84_Custom_Event_Args
{
    class Program
    {
        public class MyArgs : EventArgs
        {
            public MyArgs(int value)
            {
                Value = value;
            }

            public  int Value { get; set; }
        }

        public class Pub
        {
            public event EventHandler<MyArgs> OnChange = delegate
            {
                Console.WriteLine("Delegate called");
            };

            public void Raise()
            {
                OnChange(this, new MyArgs(42));
            }
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();

            p.OnChange += (sender, e) => Console.WriteLine("Event raised : {0}", e.Value);

            p.Raise();
        }
        static void Main(string[] args)
        {
            CreateAndRaise();

            Console.ReadKey();
        }
    }
}
