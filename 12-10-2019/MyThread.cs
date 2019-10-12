using DotLiquid.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreadings
{
    public class MyThread
    {
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("child"); //Child thread starts

                Thread.Sleep(200); //Child Thread Paused 

            }
        }
    }
    public class Text
    {
        public void Call()
        {
            MyThread mt = new MyThread();
            Thread t = new Thread(new ThreadStart(mt.Run));
            t.Start();

            t.Join();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("main"); //In Main: Creating the Child thread
                try
            {
                t.Abort();
            }
            catch (ThreadAbortException tae)
            {
                Console.WriteLine(tae.ToString()); //Thread Abort Exception
            }

                Console.WriteLine("End of Main");
                Console.ReadKey();
            }
        }
    }
}
     



