using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOP_Course10
{
    class ThreadInformation
    {
        /*static Object obj = new object();

        public static void Main()
        {
            ThreadPool.QueueUserWorkItem(ShowThreadInformation); //What is a threadpool ?
                                                                 //It's a bucket with threads which already have certain proprieties.
                                                                 //Here we call the function "ShowThreadInformation" and let a random thread from the ThreadPool execute it
            var th1 = new Thread(ShowThreadInformation); //th1 and th2 are threads created manually and are NOT from the threadpool 
            th1.Start();
            var th2 = new Thread(ShowThreadInformation);
            th2.IsBackground = true;
            th2.Start();
            //Thread.Sleep(500);
            ShowThreadInformation(null); //We pass null, so the computer don't know which thread it has to pick. So it picks from the threadpool ! (that's why we get at the end: is from threadpool (yes!))
        }

        private static void ShowThreadInformation(Object state)
        {
            lock(obj)
            {
                var th = Thread.CurrentThread;
                Console.WriteLine("Managed Thread #{0}: ", th.ManagedThreadId);
                Console.WriteLine("     Background thread: {0}", th.IsBackground);
                Console.WriteLine("     Thread pool thread: {0}", th.IsThreadPoolThread);
                Console.WriteLine("     Priority: {0}", th.Priority);
                Console.WriteLine("     Culture: {0}", th.CurrentCulture.Name);
                Console.WriteLine("     UI culture: {0}", th.CurrentUICulture.Name);
                Console.WriteLine();
            }
        }*/
    }
}
