using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTaskWaitAny
{
    //Listing 1-15 Using Task.WaitAny
    class Program
    {
        static void Main(string[] args)
        {
            Task<int>[] tasks = new Task<int>[3];
            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(2000);

                return 1;
            });
            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);

                return 1;
            });
            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(3000);

                return 1;
            });

            while (tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];
                Console.Write(completedTask.Result);
                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }
        }
    }
}
