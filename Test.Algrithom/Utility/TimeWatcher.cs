using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Algrithom.Utility
{
    class TimeWatcher
    {
        public delegate List<int> TestDelegate(List<int> array);

        public static void StartWatchAction(Action<List<int>> func, List<int> array)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            func(array);

            watch.Stop();

            Console.WriteLine(watch.Elapsed);
        }

        public static void StartWatchDelegate(TestDelegate func, List<int> array, out List<int> result)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            result = func(array);

            watch.Stop();

            Console.WriteLine(watch.Elapsed);
        }

        public static void StartWatchFunc(Func<List<int>, List<int>> func, List<int> array, out List<int> result)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            result = func(array);

            watch.Stop();

            Console.WriteLine(watch.Elapsed);
        }

    }
}
