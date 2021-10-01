using System;
using System.Threading;

namespace ThreadClassExample
{
    class ThreadExample
    {
        public void CallDisplayAsynchronously()
        {
            Console.WriteLine("In CallDisplayAsynchronously");
            //Thread t = new Thread(() => { Display(); });// this line is essentially 12 and 13 tgt
            //ThreadStart start = new ThreadStart(Display1);//12
            Thread tp = new Thread(new ParameterizedThreadStart(DisplayParameter));
            //Thread t1 = new Thread(start);//13
            Console.WriteLine("Before Starting Thread");//synchronous

            //t.Start();//asynchronous
            //t1.Start();//asynchronous
            tp.Start("This is new");
            Console.WriteLine("Started Thread");//synchronous

            //t = new Thread(() => { Display2(); });
            //t.Start();
            //for (int i = 0; i < 5; i++)
            //{
            //    Thread.Sleep(1000);
            //    if (i == 2)//force to run synchrnously only show the display
            //    {
            //        t.Join();
            //    }
            //    Console.WriteLine("I am in Main Thread");
            //}
        }
        public void DisplayParameter(object str)
        {
            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("I am in Display: " + str.ToString());
            }           
        }
        public void Display()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("I am in Display");
            }
        }
        public void Display1()
        {
            Console.WriteLine("I am in Display1");
        }
        public void Display2()
        {
            Console.WriteLine("I am in Display2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreadExample t = new ThreadExample();
            Console.WriteLine("Calling the Normal Display Method");
            //t.Display();
            Console.WriteLine("Calling the Thread Display Method");
            t.CallDisplayAsynchronously();
            Console.ReadLine();
        }
    }
}
