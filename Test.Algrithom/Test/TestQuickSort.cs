using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Algrithom.Utility;

namespace Test.Algrithom.Test
{
    public class TestQuickSort
    {
        public static void TestSimpleQuickSort()
        {
            List<int> intArray = TestData.GetListFromString();
            List<int> result = new List<int>();
            TimeWatcher.StartWatchFunc(QuickSort.SimpleQuickSort, intArray, out result);
            //TimeWatcher.StartWatchDelegate(SimpleQuickSort, intArray, out result);
        }

        /// <summary>
        /// POJ 2388
        /// </summary>
        /// <param name="count"></param>
        public static void TestRandomQuickSort(int count)
        {
            List<int> intArray = TestData.GetRandom(count, 1, 100);
                      
            List<int> result = new List<int>();
            TimeWatcher.StartWatchFunc(QuickSort.SimpleQuickSort, intArray, out result);

            Console.WriteLine(result[result.Count / 2]);
        }
    }
}
