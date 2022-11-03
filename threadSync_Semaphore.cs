using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course10
{
    class threadSync_Semaphore
    {
        //Semaphore
        //We use Semaphore in the case where we have to give multiple threads access to a resource at the same time (execute the same function for exemple)
        static Semaphore _semaphoreEvent = new Semaphore(initialCount: 2, maximumCount: 3); //The initialCount is the number of threads that can access the semaphore at the same time at the beginning
                                                                                            //The maximumCount is the number of threads that can access the semaphore at the same time
                                                                                            //With the parameter (1,1) it behaves exactly as the mutex. We initialize all the threads and then write sequencially
                                                                                            //With the parameter (2,2) now we initialize all the threads BUT we write with two threads at THE SAME TIME
        static void Main(string[] args)
        {
            //Create 5 Threads --- All Threads want to File Operation
            for (int i = 0; i < 10; i++)
            {
                new Thread(WriteOperation).Start();
            }
        }

        public static void WriteOperation()
        {
            //Actual: File Operation
            //Simulate with Sleep
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is Waiting to Write");
            _semaphoreEvent.WaitOne(); //The thread will wait here until the mutexEvent is set to true

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is Writing");
            Thread.Sleep(4000); //Simulate: FileOperation
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has completed writing");

            _semaphoreEvent.Release(); //As the thread finish it's work it will send a signal for the other one to start
        }
    }
}
