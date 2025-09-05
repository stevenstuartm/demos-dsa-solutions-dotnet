using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet
{
    internal static partial class Solutions
    {
        public static void PlusMinus(List<int> arr)
        {
            var positiveNumbers = 0;
            var negativeNumbers = 0;
            var zeroNumbers = 0;

            for(var i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    ++positiveNumbers;
                }
                else if (arr[i] < 0)
                {
                    ++negativeNumbers;
                }
                else if (arr[i] == 0)
                {
                    ++zeroNumbers;
                }
            }

            Console.WriteLine($"{((double)positiveNumbers / arr.Count):0.000000}");
            Console.WriteLine($"{((double)negativeNumbers / arr.Count):0.000000}");
            Console.WriteLine($"{((double)zeroNumbers / arr.Count):0.000000}");
        }
    }
}