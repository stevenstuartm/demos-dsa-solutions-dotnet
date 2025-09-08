using demos.dsa.solutions.dotnet.Common;

namespace demos.dsa.solutions.dotnet.Examples
{
    internal static partial class Solutions
    {
        public static SingleListNode AddTwoNumbers(SingleListNode l1, SingleListNode l2)
        {
            var fakehead = new SingleListNode(-1);
            var start = fakehead;
            var overflow = 0;

            while (l1 != null || l2 != null)
            {
                var l1Value = l1 == null ? 0 : l1.val;
                var l2Value = l2 == null ? 0 : l2.val;

                var newNode = new SingleListNode((l1Value + l2Value + overflow)%10);
                start.next = newNode;
                start = start.next;

                overflow = (l1Value + l2Value + overflow) / 10;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }

            if (overflow == 1)
            {
                var newNode = new SingleListNode(1);
                start.next = newNode;
            }

            return fakehead.next;
        }
    }
}