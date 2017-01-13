using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingThreadWithThreadClass
{
    //Listing 1-1 UsingThreadWithThreadClass
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc {0}", i);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(ThreadMethod);
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main Thread: Do Something");
                Thread.Sleep(0);
            }
            t.IsBackground = true;
            t.Join();
            Console.WriteLine("After");
           
        }
    }
}
