namespace demos.dsa.solutions.dotnet.Common
{
    public class SingleListNode
    {
        public int val;
        public SingleListNode? next;

        public SingleListNode(int val = 0, SingleListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}