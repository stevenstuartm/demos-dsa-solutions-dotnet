using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet.Examples
{
    internal static partial class Solutions
    {
        public static int[] CountingSort(List<int> arr)
        {
            //assumes that no number in arr is greater than 100
            
            int[] result = new int[100];

            for (int i = 0; i < arr.Count; i += 100)
            {
                for (int j = i; j < i + 100; j++)
                {
                    result[arr[j]]++;
                }
            }

            return result;
        }
    }
}