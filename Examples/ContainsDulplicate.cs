using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet
{
    internal static partial class Solutions
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            return nums.Count() > nums.Distinct().Count();

            //OR ....
            // var myDictionary = new Dictionary<int, int>();
        
            // foreach(var num in nums)
            // {
            //     if(myDictionary.ContainsKey(num))
            //     {
            //         return true;
            //     }
                
            //     myDictionary.Add(num, 1);
            // }
            
            // return false;
        }
    }
}