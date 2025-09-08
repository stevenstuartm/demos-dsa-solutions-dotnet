using demos.dsa.solutions.dotnet.Common;

namespace demos.dsa.solutions.dotnet.Examples.Examples
{
//    Given the head of a singly linked list, return the middle node of the linked list.
//    If there are two middle nodes, return the second middle node.

//Example 1:
//Input: head = [1, 2, 3, 4, 5]
//Output: [3, 4, 5]
//Explanation: The middle node of the list is node 3.

//Example 2:
//Input: head = [1, 2, 3, 4, 5, 6]
//Output: [4, 5, 6]
//Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.

    internal static partial class Solutions
    {
        public static SingleListNode MiddleoftheLinkedList(SingleListNode head)
        {
            var nodeCount = 1;
            var nodeDict = new Dictionary<int, SingleListNode>() { { nodeCount, head } };
            var nextNode = head.next;

            while (nextNode != null)
            {
                nodeCount++;
                nodeDict.Add(nodeCount, nextNode);
                nextNode = nextNode.next;
            }

            if (nodeCount % 2 == 0)
            {
                return nodeDict[(nodeCount / 2) + 1];
            }
            else
            {
                return nodeDict[(nodeCount + 1) / 2];
            }
        }
    }
}
