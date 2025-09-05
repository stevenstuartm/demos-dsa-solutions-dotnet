using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet
{
    internal static partial class Solutions
    {
        public static void MinMaxSum(List<int> arr)
        {
            long sumOfAllNumbers = 0;
            long minimum = long.MaxValue;
            long maximum = 0;
            
            for (int i = 0; i < 5; i++)
            {
                sumOfAllNumbers += arr[i];
                
                if (arr[i] < minimum)
                    minimum = arr[i];


                if (arr[i] > maximum)
                    maximum = arr[i];
            }


            //the minimum and maximum sum of two numbers within the array
            
            Console.WriteLine(string.Format("{0} {1}", sumOfAllNumbers - maximum, sumOfAllNumbers - minimum));
        }
    }
}