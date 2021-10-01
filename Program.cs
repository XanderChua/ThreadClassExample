using System;
using System.Threading;

namespace ThreadClassExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass t = new ThreadClass();
            Console.WriteLine("Hello World!");
            t.Callthread();
        }
        class ThreadClass
        {
            public void Callthread()
            {
                Thread t = new Thread(Display);
                t.Start();
            }
            public void Display()
            {
                for (int i = 1; i < 100; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(i + " second passed");
                }
            }
        }
    }
}
