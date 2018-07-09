using System;
 
using System.Threading;

namespace _1_5_ThreadStatic
{
    class Program
    {
        // By marking with ThreadStatic annotation, the data is not local to the thread.
        // Removing the annotation shares the data (the total will move to 20
        //[ThreadStatic]
        public static int _field;

        private static void localData(Object _char)
        {
           for(int x=0; x < 10; x++)
            {
                _field++;
                Console.WriteLine("Thread {0} : {1}", (string)_char, _field);

            }
        }
        static void Main(string[] args)
        {
            /* *********************************************************************************
             
            Replacing anonymous function with delegate for clarity

            new Thread(()=> {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A : {0}", _field);

                }
            }).Start();

            new Thread(() => {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread B : {0}", _field);

                }
            }).Start();
           *********************************************************************************************** */

            new Thread(localData).Start("A");
            new Thread(localData).Start("B");

            Console.ReadKey();



        }
    }
}
