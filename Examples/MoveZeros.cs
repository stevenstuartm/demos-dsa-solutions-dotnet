using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet
{
    internal static partial class Solutions
    {
        public static void MoveZeroes(int[] nums)
        {
            int nonZeroIdx = 0;

            if(nums.Length <= 1)
            {
                return;
            } 
            
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[nonZeroIdx] = nums[i];

                    if (i != nonZeroIdx)
                    {
                        nums[i] = 0;
                    }

                    nonZeroIdx++;
                }
            }
        }
    }
}