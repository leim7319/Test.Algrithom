using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Algrithom.Utility
{
    public class QuickSort
    {

        public static List<int> SimpleQuickSort(List<int> a)
        {
            Random r = new Random();
            List<int> less = new List<int>();
            List<int> greater = new List<int>();
            if (a.Count <= 1)
                return a;
            //int pos = r.Next(a.Count);
            int pos = a.Count / 2;

            int pivot = a[pos];
            a.RemoveAt(pos);
            foreach (int x in a)
            {
                if (x <= pivot)
                {
                    less.Add(x);
                }
                else
                {
                    greater.Add(x);
                }
            }
            return Concat(SimpleQuickSort(less), pivot, SimpleQuickSort(greater));
        }

        private static List<int> Concat(List<int> less, int pivot, List<int> greater)
        {
            List<int> sorted = new List<int>(less);
            sorted.Add(pivot);
            foreach (int i in greater)
            {
                sorted.Add(i);
            }

            return sorted;
        }
    }
}
