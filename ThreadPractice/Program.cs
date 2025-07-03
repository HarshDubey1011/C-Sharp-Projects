using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace ThreadPractice
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            AutoResetEvent wh = new AutoResetEvent(false);

            Thread t1 = new Thread(delegate ()
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine("f1:" + i);
                    if (i % 50 == 0)
                    {
                        Console.WriteLine("waiting");
                        wh.WaitOne(); // pauses here
                    }
                }
            });

            Thread signalThread = new Thread(delegate ()
            {
                for (int j = 0; j < 4; j++)
                {
                    Thread.Sleep(1000); // simulate some delay
                    Console.WriteLine("Signaling");
                    wh.Set(); // lets t1 continue
                }
            });

            t1.Start();
            signalThread.Start();
        }

        static void Main2(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod1));
            }
            Console.Read();
        }
        public static void MyMethod1(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Background: {thread.IsBackground}, Thread Pool: {thread.IsThreadPoolThread}, Thread ID: {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }

        static void Main3(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(MyMethod)
                {
                    Name = "Thread" + i
                };
                thread.Start();
            }
            Console.Read();
        }
        public static void MyMethod(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Background: {thread.IsBackground}, Thread Pool: {thread.IsThreadPoolThread}, Thread ID: {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }

        static void Main4(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                MethodWithThread();
                MethodWithThreadPool();
            }
            //Warmup Code start
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Execution using Thread");
            stopwatch.Start();
            MethodWithThread();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThread is : " +
                                 stopwatch.ElapsedTicks.ToString());

            stopwatch.Reset();
            Console.WriteLine("Execution using Thread Pool");
            stopwatch.Start();
            MethodWithThreadPool();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThreadPool is : " +
                                 stopwatch.ElapsedTicks.ToString());

            Console.Read();
        }

        public static void MethodWithThread()
        {
            for(int i = 0;i<10;i++)
            {
                Thread thread = new Thread(Test);
                thread.Start();
            }
        }

        public static void MethodWithThreadPool()
        {
            for(int i = 0;i < 10;i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
            }
        }

        public static void Test(object obj) { }
            static void Main(string[] args)
            {
                Console.WriteLine("Main Thread Started");

                //Main Thread creating three child threads
                Thread thread1 = new Thread(Method1);
                Thread thread2 = new Thread(Method2);
                Thread thread3 = new Thread(Method3);

                thread1.Start();
                thread2.Start();
                thread3.Start();

                thread1.Join(); //Block Main Thread until thread1 completes its execution
                thread2.Join(); //Block Main Thread until thread2 completes its execution
                                //Now, Main Thread will not wait for thread3 to complete its execution

                Console.WriteLine("Main Thread Ended");
                Console.Read();
            }

            static void Method1()
            {
                Console.WriteLine("Method1 - Thread1 Started");
                Thread.Sleep(1000);
                Console.WriteLine("Method1 - Thread 1 Ended");
            }

            static void Method2()
            {
                Console.WriteLine("Method2 - Thread2 Started");
                Thread.Sleep(2000);
                Console.WriteLine("Method2 - Thread2 Ended");
            }

            static void Method3()
            {
                Console.WriteLine("Method3 - Thread3 Started");
                Thread.Sleep(5000);
                Console.WriteLine("Method3 - Thread3 Ended");
            }
        
    
}
}
