using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Algrithom.LinkTable
{
   public  class CircleLinkTableNode<T>
    {
       public T Data;
       public CircleLinkTableNode<T> Next;
    }

   public class CircleLinkTable
   {
       public static void Test(int count)
       {
           List<CircleLinkTableNode<int>> list = new List<CircleLinkTableNode<int>>();

           if (count >= 3)
           {
               // 构建循环链表
               for (int i = count; i > 0; i--)
               {
                   CircleLinkTableNode<int> node = new CircleLinkTableNode<int>();
                   node.Data = i;
                   if (i == count)
                   {
                       node.Next = null;
                   }
                   else
                   {
                       node.Next = list.Last();
                   }
                   list.Add(node);
               }
               list.First().Next = list.Last();
               list.Reverse();

               // 
               StartRemoveNode(list.First());
           }
       }

       public static void StartRemoveNode(CircleLinkTableNode<int> node)
       {
           CircleLinkTableNode<int> head = node;
           int i = 1;
           while(node!=node.Next.Next.Next)
           {
               head = node.Next.Next.Next;
               node.Next.Next = head;
               node = head;
           }
           Console.WriteLine(node.Next.Data);
       }
   }
}
