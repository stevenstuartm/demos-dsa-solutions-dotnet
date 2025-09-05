namespace demos.dsa.solutions.dotnet
{
    internal static partial class Solutions
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            return InorderTraversal_UsingIteration(root);
        }

        private static IList<int> InorderTraversal_UsingIteration(TreeNode root)
        {
            var res = new List<int>();

            while (root != null)
            {
                if (root.left == null)
                {
                    res.Add(root.val);
                    root = root.right;
                }
                else
                {
                    var pre = root.left;
                    while (pre.right != null && pre.right != root)
                    {
                        pre = pre.right;
                    }

                    if (pre.right == null)
                    {
                        pre.right = root;
                        root = root.left;
                    }
                    else
                    {
                        pre.right = null;
                        res.Add(root.val);
                        root = root.right;
                    }
                }
            }

            return res;
        }
        private static void InorderTraversal_UsingRecursion(TreeNode? root, List<int> result)
        {
            if (root == null)
            {
                return;
            }

            InorderTraversal_UsingRecursion(root.left, result);

            result.Add(root.val);

            //this assumes that the left will never have a reference to the root. If it did then this would not work.
            InorderTraversal_UsingRecursion(root.right, result);
        }

        public class TreeNode {
            public int val;
            public TreeNode? left;
            public TreeNode? right;
            public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null) {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}