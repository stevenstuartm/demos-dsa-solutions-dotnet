using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet.Examples
{
    internal static partial class Solutions
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int diagonal1Sum = 0;
            int diagonal2Sum = 0;
            
            for(int i = 0; i < arr.Count; i++)
            {
                diagonal1Sum += arr[i][i];
                diagonal2Sum += arr[i][arr.Count - i - 1];
            }
            
            return Math.Abs(diagonal1Sum - diagonal2Sum);
        }
    }
}