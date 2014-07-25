using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test.Algrithom.LinkTable;
using Test.Algrithom.Test;
using Test.Algrithom.Utility;

namespace Test.Algrithom
{
    class Program
    {
        static void Main(string[] args)
        {
            //var count = Console.ReadLine();
            //while (count != "0")
            //{
            //    TestQuickSort.TestRandomQuickSort(int.Parse(count));
            //    count = Console.ReadLine();
            //}

            //int i = 1;
            //while (i != 0)
            //{
            //    string count = Console.ReadLine();

            //    i = int.Parse(count);

            //    CircleLinkTable.Test(i);
            //}

            //Program someClass = new Program();
            //Thread backgroundThread = new Thread(someClass.DoWork);
            //backgroundThread.IsBackground = true;
            //backgroundThread.Start();
            //Console.WriteLine("Closing the program....");

            //for (int i = 0; i < 10; i++)
            //{
            //    Thread thread = new Thread(() => Console.Write(i));
            //    thread.Start();
            //}
            
            for (int i = 0; i < 10; i++)
            {
                int temp = i;
                Thread thread = new Thread(() => Console.Write(temp));
                thread.Start();
            }

            Console.ReadLine();
        }

        void DoWork()
        {
            try
            {
                Thread.MemoryBarrier();
                Console.WriteLine("Doing some work...");
                Thread.Sleep(1000);
            }
            finally
            {
                Console.WriteLine("This should be always executed");
            }
            Console.ReadLine();
        }

    }

}
