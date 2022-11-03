/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course10
{
    class Join
    {
        static Thread thread1, thread2;
        static void Main()
        {
            thread1 = new Thread(ThreadProc);
            thread1.Name = "Thread1";
            thread1.Start();
            thread1.Join();
            thread2 = new Thread(ThreadProc);
        }

        private static void ThreadProc()
        {
            Console.WriteLine("\nCurrent Thread: {0}", Thread.CurrentThread.Name);
            if(Thread.CurrentThread.Name == "Thread1" && thread2.ThreadState != ThreadState.Unstarted)
            {
                Console.WriteLine(">>> Joining Thread2");
                thread2.Join();
                Console.WriteLine(">>> Completed Thread2");
            }

            Thread.Sleep(4000);
            Console.WriteLine("\nCurrent Thread: {0}", Thread.CurrentThread.Name);
            Console.WriteLine("Thread1: {0}", thread1.ThreadState);
        }
    }
}
*/