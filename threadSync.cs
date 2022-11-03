//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP_Course10
//{
//    class ThreadSync
//    {
//        //lock (to make thread1 to start, write and complete and then thread2 to start, write and complete)
//        //if you want to compare, just comment the lock(_threadLock) in the WriteOperation function and get out the sleep and console.WriteLine()
//        static object _threadLock = new object();
//        static void Main(string[] args)
//        {
//            //Create 5 Threads --- All Threads want to File Operation
//            for (int i = 0; i < 5; i++)
//            {
//                new Thread(WriteOperation).Start();
//            }
//        }

//        public static void WriteOperation()
//        {
//            //Actual: File Operation
//            //Simulate with Sleep
//            lock (_threadLock) //"Lock" function lock the current thread happening so it can carry on the operation it is doing and then the other thread can start
//                               //Problem with the "lock" function, we can't use 'try catch' in it. So that's why we use the "Monitor" (next code)
//            {
//                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is writing to the file");
//                Thread.Sleep(2000); //Simulate: FileOperation
//                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has completed writing");
//            }


//        }
//    }
//}
