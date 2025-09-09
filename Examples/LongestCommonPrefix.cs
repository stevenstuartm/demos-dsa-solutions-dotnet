using System.Text;

namespace demos.dsa.solutions.dotnet.Examples
{
    //Write a function to find the longest common prefix string amongst an array of strings.
    //If there is no common prefix, return an empty string "".

    internal static partial class Solutions
    {
        public static string LongestCommonPrefix(string[] strs) 
        {
            if (strs.Length == 0) return String.Empty;

            Array.Sort(strs);

            var first = strs[0];
            var last = strs[strs.Length - 1];
            var strbuilder = new StringBuilder();
            
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != last[i])
                {
                    break;
                }
                strbuilder.Append(first[i]);
            }

            return strbuilder.ToString();
        }
    }
}