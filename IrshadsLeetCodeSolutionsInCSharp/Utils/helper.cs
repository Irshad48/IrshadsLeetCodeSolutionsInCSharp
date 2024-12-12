using IrshadsLeetCodeSolutionsInCSharp.Problems.LinkedList.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrshadsLeetCodeSolutionsInCSharp.Utils
{
    internal class helper
    {
        public static void PrintList(ListNode head) 
        {
            while (head != null) 
            { 
                Console.Write(head.val + " -> "); 
                head = head.next; 
            } 
            Console.WriteLine("null"); 
        }
    }
}
