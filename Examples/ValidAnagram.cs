using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet
{
    internal static partial class Solutions
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            
            var seen = new int[256];

            for (int i = 0; i < s.Length; i++)         
            {             
                seen[s[i]]++;             
                seen[t[i]]--;         
            }         

            return seen.All(x => x == 0); 
        }
    }
}