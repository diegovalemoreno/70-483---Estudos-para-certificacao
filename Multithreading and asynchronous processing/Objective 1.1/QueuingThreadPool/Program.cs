using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QueuingThreadPool
{
    //linsting 1-7 Queuing some work to the thread pool
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) =>
                {
                    Console.WriteLine("Working on a Thread from the threadPool");
                });
        }
    }
}
