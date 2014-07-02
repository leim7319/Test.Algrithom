using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DesignPatterns.DesignPatterns;

namespace Test.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonSimpleLock s = SingletonSimpleLock.Instance;
            s.Test();

            Console.ReadLine();
        }
    }
}
