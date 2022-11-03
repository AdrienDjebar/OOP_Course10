/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course10
{
    class threadSync_Mutex
    {
        //Mutex
        //We use the Mutex where we only have to give permission to a single thread (unlike the Semaphore where we can give permission to multiple threads)
        static Mutex _mutexEvent = new Mutex(); //The initial condition is not set because it will automatically set it to true when the first thread start
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
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is Waiting to Write");
            _mutexEvent.WaitOne(); //The thread will wait here until the mutexEvent is set to true

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is Writing");
            Thread.Sleep(4000); //Simulate: FileOperation
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has completed writing");

            _mutexEvent.ReleaseMutex(); //As the thread finish it's work it will send a signal for the other one to start
        }
    }
}
*/