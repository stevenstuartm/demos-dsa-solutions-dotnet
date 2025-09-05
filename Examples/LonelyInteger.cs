using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet
{
    internal static partial class Solutions
    {
        public static int Lonelyinteger(List<int> a)
        {
            int temp = a[0];
            
            for(int i = 1; i < a.Count; i++)
            {
                temp ^= a[i];
            }
            
            return temp;
        }
    }
}