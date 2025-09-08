using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;

namespace demos.dsa.solutions.dotnet.Examples
{
    internal static partial class Solutions
    {
        public static IEnumerable<int> GetMultiples(int number)
        {
            var result = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (i % number == 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}