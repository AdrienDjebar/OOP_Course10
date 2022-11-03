/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course10
{
    class ThreadSync_monitor
    {
        //lock (to make thread1 to start, write and complete and then thread2 to start, write and complete)
        static object _threadLock = new object();
        static void Main(string[] args)
        {
            //Create 5 Threads --- All Threads want to File Operation
            for (int i = 0; i < 5; i++)
            {
                new Thread(WriteOperation).Start();
            }
        }

        public static void WriteOperation()
        {
            //Actual: File Operation
            //Simulate with Sleep
            try
            {
                //"Lock" and "Monitor" is the same thing. "Lock" and "Monitor" fold the code so that it can be synchronized with the different threads
                //but only "Monitor" allow to use the try catch statement 
                Monitor.Enter(_threadLock);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is writing to the file");
                Thread.Sleep(2000); //Simulate: FileOperation
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has completed writing");
            }
            catch
            {
                Console.WriteLine("Exception Occured");
            }
            finally
            {
                Monitor.Exit(_threadLock);
            }

        }
    }
}
*/