using demos.dsa.solutions.dotnet.Common;

namespace demos.dsa.solutions.dotnet
{
    internal static partial class Solutions
    {
       public static bool IsPalindrome(SingleListNode head)
    {
        var listSize = Listsize(head);
        ListNodePalindromeResult p = IsPalindromeRecurse(head, listSize);

        return p.IsPalindrome;
    }

        private static ListNodePalindromeResult IsPalindromeRecurse(SingleListNode head, int length)
        {
            if (head == null || length == 0)
            {
                return new ListNodePalindromeResult(null, true);
            }
            else if(length == 1)
            {
                return new ListNodePalindromeResult(head.next, true);
            }
            else if(length == 2)
            {
                return new ListNodePalindromeResult(head.next.next, head.val == head.next.val);
            }

            ListNodePalindromeResult res = IsPalindromeRecurse(head.next, length - 2);

            if (!res.IsPalindrome || res.Node == null)
            {
                return res;
            }
            else
            {
                res.IsPalindrome = head.val == res.Node.val;
                res.Node = res.Node.next;

                return res;
            }
        }

        private static int Listsize(SingleListNode rootNode)
        {
            var count = 0;

            while (rootNode!= null)
            {
                rootNode = rootNode.next;
                count++;
            }

            return count;
        }

        private class ListNodePalindromeResult
        {
            public ListNodePalindromeResult(SingleListNode node, bool isPalindrome)
            {
                Node = node;
                IsPalindrome = isPalindrome;
            }

            public SingleListNode Node;
            public bool IsPalindrome;
        }


        public static bool FasterIsPalindrome(SingleListNode head) {
            if (head == null) return true;
            var count = 0;
            var start = head;
            while (start != null)
            {
                start = start.next;
                count++;
            }
            head = ReverseBetween(head, (int)Math.Ceiling(count/2.0) + 1, count);

            var index = 1;
            var end = head;
            while (index < Math.Ceiling(count/2.0) + 1)
            {
                end = end.next;
                index++;
            }

            start = head;
            while (end != null)
            {
                if (start.val != end.val)
                {
                    return false;
                }

                end = end.next;
                start = start.next;
            }

            return true;      
    }
            public static SingleListNode ReverseBetween(SingleListNode head, int m, int n)
        {
            var fakehead = new SingleListNode(-1);
            fakehead.next = head;

            var start = fakehead;
            var count = 1;
            while (count < m)
            {
                start = start.next;
                count++;
            }

            var next = start.next;
            while (count++ < n)
            {
                var firstNode = next.next;
                next.next = firstNode.next;
                firstNode.next = start.next;
                start.next = firstNode;
            }

            return fakehead.next;
        }
    }
}