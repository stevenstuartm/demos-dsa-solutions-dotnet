using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;

namespace demos.dsa.solutions.dotnet
{
    internal static partial class Solutions
    {
        public static void MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            var aindex = m - 1;
            var bindex = n - 1;

            while (aindex >= 0 || bindex >= 0)
            {
                var avalue = aindex >= 0 ? nums1[aindex] : int.MinValue;
                var bvalue = bindex >= 0 ? nums2[bindex] : int.MinValue;

                if (avalue > bvalue)
                {
                    nums1[aindex + bindex + 1] = avalue;
                    aindex--;
                }
                else
                {
                    nums1[aindex + bindex + 1] = bvalue;
                    bindex--;
                }
            }
        }
    }
}