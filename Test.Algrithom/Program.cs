using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Algrithom.Test;
using Test.Algrithom.Utility;

namespace Test.Algrithom
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = Console.ReadLine();
            while (count != "0")
            {
                TestQuickSort.TestRandomQuickSort(int.Parse(count));
                count = Console.ReadLine();
            }
             
            Console.ReadLine();

        }
    }
}
