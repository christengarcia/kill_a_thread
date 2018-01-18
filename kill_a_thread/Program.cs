/*
 * C# Program to Kill a Thread
 */

using System;
using System.Threading.Tasks;
using System.Threading;

namespace kill_a_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadingClass th = new ThreadingClass();
            Thread thread1 = new Thread(th.DoStuff);
            thread1.Start();
            Console.WriteLine("Press any key to exit!!!");
            Console.ReadKey();
            th.Stop();
            thread1.Join();
        }
    }


}
