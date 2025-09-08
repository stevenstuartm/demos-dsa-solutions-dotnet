using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet.Examples
{
    internal static partial class Solutions
    {
        public static bool IsHappy(int n)
        {
            var visited = new Dictionary<int, bool>();
            var next = n;

            while (!visited.ContainsKey(next))
            {
                visited.Add(next, true);
                
                var start = next;
                next = 0;

                while (start != 0)
                {
                    next += (start % 10) * (start % 10);
                    start /= 10;
                }

                if (next == 1) return true;
            }

            return false;
        }
    }
}