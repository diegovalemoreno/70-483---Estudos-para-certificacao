﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingParameterizedThread
{
    //Listing 1-2 UsingParameterizedThread
    class Program
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i <(int)o; i++)
            {
                Console.WriteLine("ThreadProc {0}", i);
                Thread.Sleep(0);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(15);
            t.Join();
        }
    }
}
