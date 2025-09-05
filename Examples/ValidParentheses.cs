namespace demos.dsa.solutions.dotnet.Leetcode
{
    //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    //An input string is valid if:
    //Open brackets must be closed by the same type of brackets.
    //Open brackets must be closed in the correct order.
    //Every close bracket has a corresponding open bracket of the same type.

    internal static partial class Solutions
    {
         public static bool ValidParentheses(string s)
         {
            if (string.IsNullOrEmpty(s)) return true;

            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> brackets = new Dictionary<char, char>()
            {
                {')', '(' },
                {'}', '{' },
                {']', '[' },
            };

            foreach (var ch in s)
            {
                if (brackets.ContainsKey(ch))
                {
                    var expected = brackets[ch];

                    if (stack.Count == 0 || expected != stack.Peek())
                        return false;
                    
                    stack.Pop();
                }
                else
                {
                    stack.Push(ch);
                }
            }

            return stack.Count == 0;
        }
    }
}