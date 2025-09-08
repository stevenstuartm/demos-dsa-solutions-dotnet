using demos.dsa.solutions.dotnet.Common;

namespace demos.dsa.solutions.dotnet.Examples.Leetcode
{
    //You are given the heads of two sorted linked lists list1 and list2.
    //Merge the two lists into one sorted list.The list should be made by splicing together the nodes of the first two lists.
    //Return the head of the merged linked list.

    internal static partial class Solutions
    {
        public static SingleListNode? MergeTwoLists(SingleListNode? list1, SingleListNode? list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            if (list2.val > list1.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
    }
}