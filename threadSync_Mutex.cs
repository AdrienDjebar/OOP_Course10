using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course10
{
    class threadSync_Mutex
    {
        //Mutex
        static Mutex _mutexEvent = new Mutex(); //The initial condition is not set because it will automatically set it to true when the first thread start
        static void Main(string[] args)
        {
            //Create 2 Threads of each --- Each pair of theads want to respectively WriteOperation and ReadOperation
            for (int i = 0; i < 2; i++)
            {
                new Thread(WriteOperation).Start();
                new Thread(ReadOperation).Start();
            }
        }

        public static void WriteOperation()
        {
            //Actual: File Operation
            //Simulate with Sleep
            Console.WriteLine($"WW_Thread {Thread.CurrentThread.ManagedThreadId} is Waiting to Write");
            _mutexEvent.WaitOne(); //The thread will wait here until the mutexEvent is set to true

            Console.WriteLine($"WW_Thread {Thread.CurrentThread.ManagedThreadId} is Writing");
            Thread.Sleep(4000); //Simulate: FileOperation
            Console.WriteLine($"WW_Thread {Thread.CurrentThread.ManagedThreadId} has completed writing");

            _mutexEvent.ReleaseMutex(); //As the thread finish it's work it will send a signal for the other one to start
        }

        public static void ReadOperation()
        {
            //Actual: Read Operation
            //Simulate with Sleep
            Console.WriteLine($"RR_Thread {Thread.CurrentThread.ManagedThreadId} is Waiting to Read");
            _mutexEvent.WaitOne(); //The thread will wait here until the mutexEvent is set to true

            Console.WriteLine($"RR_Thread {Thread.CurrentThread.ManagedThreadId} is Reading");
            Thread.Sleep(4000); //Simulate:ReadFileOperation
            Console.WriteLine($"RR_Thread {Thread.CurrentThread.ManagedThreadId} has completed reading");

            _mutexEvent.ReleaseMutex(); //As the thread finish it's work it will send a signal for the other one to start
        }
    }
}
