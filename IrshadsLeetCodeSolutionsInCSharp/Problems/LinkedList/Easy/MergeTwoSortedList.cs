using IrshadsLeetCodeSolutionsInCSharp.Problems.String.Easy;
using IrshadsLeetCodeSolutionsInCSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrshadsLeetCodeSolutionsInCSharp.Problems.LinkedList.Easy
{

    /*
    Problem Statement
    You are given the heads of two sorted linked lists list1 and list2.
    Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
    Return the head of the merged linked list.

    Example 1:
    Input: list1 = [1,2,4], list2 = [1,3,4]
    Output: [1,1,2,3,4,4]
    Example 2:

    Input: list1 = [], list2 = []
    Output: []
    Example 3:

    Input: list1 = [], list2 = [0]
    Output: [0]
     

    Constraints:

    The number of nodes in both lists is in the range [0, 50].
    -100 <= Node.val <= 100
    Both list1 and list2 are sorted in non-decreasing order.

     */
    /*


    ############################################################
    EXPLAINATION
    ############################################################
    What are we doing?
    We're merging two sorted linked lists into one sorted linked list.

    What's a linked list?
    Imagine a chain where each link has a value and points to the next link. That's a linked list. In programming, each link is called a "ListNode."

    Class ListNode:
    This class defines each link in our chain. Each ListNode has a value (val) and a pointer to the next link (next).

    Class Solution and Method MergeTwoLists:
    This method takes two linked lists (list1 and list2) and combines them into one sorted linked list.

    Handling special cases:
    If either list is empty (null), we simply return the other list.

    Setting up:
    We create a dummy node to help build our new list. The current node points to where we'll be adding new links.

    Main merging loop:
    We compare the current values of list1 and list2. We attach the smaller value to our new list and move to the next node in that list.
    We keep doing this until we reach the end of one of the lists.

    Finish off:
    Once one list is finished, we attach the remaining part of the other list (if any) to our new list.

    Return the result:
    We return the new merged list, which starts at dummy.next (since dummy was just a placeholder).


    Example:

    Let's consider the same elements but in linked list form:
    - `list1`: 1 -> 3 -> 5
    - `list2`: 2 -> 4 -> 6

   
   Detailed Steps in Action

    1.Initialize:
       - `dummy` node is created.
       - `current` points to `dummy`.

    2.First Comparison:
       - Compare `1` (list1) and `2` (list2).
       - `1` is smaller, so attach it to `current.next` and move `list1` forward.
       - Move `current` forward.

    3.Next Comparisons:
       - Compare `3` (list1) and `2` (list2).
       - `2` is smaller, so attach it to `current.next` and move `list2` forward.
       - Move `current` forward.

    4.Continue:
       - Repeat these steps until one list is exhausted.

    5.Attach Remaining Nodes:
       - Attach the remaining part of the non-exhausted list (in this case, `5` from `list1` or `6` from `list2`).

    6.Result:
       - The merged list is `1 -> 2 -> 3 -> 4 -> 5 -> 6`.

    ############################################################
    COMPLEXITIES
    ############################################################
    Time Complexity - O (n + m)
    n is the number of nodes in list1
    m is the number of nodes in list2
    Space Complexity - O(1)

    ############################################################
    USEFUL YOUTUBE LINK
    ############################################################

     https://www.youtube.com/watch?v=0ougDTvVOFI

    ############################################################
    CODE
    ############################################################
    */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class MergeTwoSortedList
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode dummy = new ListNode();
            ListNode current = dummy;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            current.next = list1 ?? list2;

            return dummy.next;
        }
        public static void RunExample()
        {
            // Create first linked list: 1 -> 3 -> 5
            ListNode list1 = new ListNode(1, new ListNode(3, new ListNode(5)));

            // Create second linked list: 2 -> 4 -> 6
            ListNode list2 = new ListNode(2, new ListNode(4, new ListNode(6)));

            // Display input linked lists
            Console.Write("Input List 1: ");
            helper.PrintList(list1);

            Console.Write("Input List 2: ");
            helper.PrintList(list2);

            // Merge the lists
            var solution = new MergeTwoSortedList();
            ListNode mergedList = solution.MergeTwoLists(list1, list2);

            // Print the merged list
            Console.Write("Merged List: ");
            helper.PrintList(mergedList);
            Console.WriteLine("\n\nTime Complexity: O(n + m)");
            Console.WriteLine(ComplexityHelper.GetSpaceComplexityBigON());
        }
    }
}
