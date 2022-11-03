using System;
using System.Linq;
using System.Threading;

namespace OOP_Course10
{   /*
    class ThreadExample
    {
        public static void ThreadProc()
        {
            Console.WriteLine("@@ Starting 2nd Thread @@");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);

                Thread.Sleep(500); //Sleep is always in milliseconds
            }
            Console.WriteLine("@@ Ending 2nd Thread @@");
        }
        static void Main()
        {
            Console.WriteLine("** Main thread Starting **");

            Thread t = new Thread(ThreadProc);
            
            t.Start();
            //Thread.Sleep(1000);


            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: For Loop Count {0}", i);
                Thread.Sleep(0);
            }

            Console.WriteLine("** Main thread Exiting **");
        }
    }*/
}