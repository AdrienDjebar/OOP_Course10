using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course10
{
    class ThreadSync_ManuelEventReset
    {
        //Manual Reset Event 
        static ManualResetEvent _mreEvent = new ManualResetEvent(false); //We set the initial condition to false so we can manually say when to pass the stop at green by using _mreEvent.Reset();

        static void Main(string[] args)
        {
            new Thread(WriteOperation).Start();

            //Create 5 Threads --- All Threads want to File Operation
            for (int i = 0; i < 5; i++)
            {
                new Thread(ReadOperation).Start();
            }
        }

        public static void WriteOperation()
        {
            //Actual: File Operation
            //Simulate with Sleep
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is writing to the file");
            _mreEvent.Reset();

            Thread.Sleep(4000); //Simulate: FileOperation
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has completed writing");

            _mreEvent.Set(); //The _mreEvent is like a red/green light for the threads
                             //The _mreEvent.Reset() lock the thread, so the current thread has to finish the execution of the code
                             //After it's finish, we send the signal that we have finished with _mreEvent.Set() so other thread can start to execute

        }
        public static void ReadOperation()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is Waiting to Read");
            _mreEvent.WaitOne(); //Even though we started the threads it's waiting for the signal to really start! Then when the signal come, boom, we execute the code
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is Reading");
            Thread.Sleep(2000); //Simulate: ReadFileOperation
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has completed Reading");
        }
    }
}
