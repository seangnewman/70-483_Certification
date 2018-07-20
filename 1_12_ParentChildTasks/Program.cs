using System;
using System.Threading.Tasks;

namespace _1_12_ParentChildTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                // Create the tasks and attach to the parent
                new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();
                return results;
            });

            var finalTask = parent.ContinueWith( parentTask =>
            {
                foreach(int i in parentTask.Result)
                {
                    Console.WriteLine(i);
                }
            });
            finalTask.Wait();   //Parent waits for all children to complete

            Console.ReadKey();
        }
    }
}
