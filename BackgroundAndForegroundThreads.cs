/*using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course10
{
    class BackgroundAndForegroundThreads
    {
        public static void Main()
        {
            Console.WriteLine("@@ Starting Main Thread @@");
            var th = new Thread(ExecuteInForeground);
            th.IsBackground = true; //If you comment or decomment this, the output will be different.
                                    //If the IsBackground = true, then after the main function has executed the "th" thread will stop instantly
                                    //but, if it's false, then it will carry on even after the execution of the main thread function
            th.Start();
            th.Join(); //The .Join enable to synchronise threads so one thread in executed completly until it pass back to the main thread.
                       //here, the main thread is started and then the th start, finish completly thanks to .join and then pass back to the main
            Thread.Sleep(1000);
            Console.WriteLine("Main thread ({0}) exiting...",
                Thread.CurrentThread.ManagedThreadId); //Getting the ID of the main thread
            Console.WriteLine("@@ Exiting Main Thread @@");
        }

        private static void ExecuteInForeground()
        {
            Console.WriteLine("** Starting Thread Function **");
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Thread ID: {0} | State: {1} | Priority: {2} | IsBackground: {3}",
                               Thread.CurrentThread.ManagedThreadId,
                               Thread.CurrentThread.ThreadState,
                               Thread.CurrentThread.Priority,
                               Thread.CurrentThread.IsBackground);
            do
            {
                Console.WriteLine("Thread {0} | Time Elapsed {1:N2} seconds",
                                    Thread.CurrentThread.ManagedThreadId,
                                    sw.ElapsedMilliseconds / 1000.0);
                Thread.Sleep(500);
            } while (sw.ElapsedMilliseconds <= 5000);
            sw.Stop();
        }
    }
}
*/