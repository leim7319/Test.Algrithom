using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// http://www.yoda.arachsys.com/csharp/singleton.html
/// http://csharpindepth.com/Articles/General/Singleton.aspx
namespace Test.DesignPatterns.DesignPatterns
{    
    /// <summary>
    /// simple thread safety
    /// </summary>
   public sealed class SingletonSimpleLock
    {
       private static SingletonSimpleLock instance = null;
       private static readonly object lockObject = new object();

       private SingletonSimpleLock()
       {
       }

       public static SingletonSimpleLock Instance
       {
           get
           {
               lock(lockObject)
               {
                   if(instance==null)
                   {
                       instance = new SingletonSimpleLock();
                   }

                   return instance;
               }
           }
       }

       public void Test()
       {
           Console.WriteLine("test");
       }
    }

    /// <summary>
    /// not quite as lazy, but thread-safe without using locks
    /// </summary>
    public sealed class SingletonNoLock
    {
        private static readonly SingletonNoLock instance = new SingletonNoLock();

        static SingletonNoLock()
        {
        }

        SingletonNoLock() 
        { 
        }

        public static SingletonNoLock Instance
        {
            get
            {
                return instance;
            }
        }
    }


    /// <summary>
    /// fully lazy instantiation
    /// </summary>
    public sealed class SingletonNested
    {
        SingletonNested()
        {
        }

        public static SingletonNested Instance
        {
            get
            {                
                return Nested.instance;
            }
        }

        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly SingletonNested instance = new SingletonNested();
        }
    }




}

