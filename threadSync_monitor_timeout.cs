using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course10
{
    class ThreadSync_monitor_timeout
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
                int maxTime = 5000; 
                
                Monitor.Enter(_threadLock);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is writing to the file");
                
                Random rnd = new Random(); //Simulate a Random Time
                int operationTime = rnd.Next(3, 10); //Simulate a Random Time
                
                Console.WriteLine("...Operation Time = " + operationTime); //Understanding how it works
                if (operationTime * 1000 > maxTime) throw new TimeoutException(); //Exemple << not how timeout exception works 
                
                Thread.Sleep(operationTime * 1000); //Simulate: FileOperation
                
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has completed writing");
            }
            catch
            {
                Console.WriteLine($"---> Thread {Thread.CurrentThread.ManagedThreadId} has timeout"); //Even though we haven't reached the "Monitor.Exit(_threadLock) part, the exception will make the actual locked thread to terminate
            }
            finally
            {
                Monitor.Exit(_threadLock);
            }

        }
    }
}
