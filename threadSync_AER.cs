/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course10
{
    class threadSync_AER
    {
        //Auto Reset EventD
        static AutoResetEvent _areEvent = new AutoResetEvent(true); //The initial condition is true so the first thread can write, the stop is green 
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
            _areEvent.WaitOne(); //The thread will wait here until the AutoResetEvent is set to true

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is Writing");
            Thread.Sleep(4000); //Simulate: FileOperation
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has completed writing");

            _areEvent.Set(); //The _areEvent is like a red/green light for the threads, but automatic. As one thread finish it will send a signal for the other one to start
        }
    }
}
*/