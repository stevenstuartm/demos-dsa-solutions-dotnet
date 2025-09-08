using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet.Examples
{

//    Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

//Each letter in magazine can only be used once in ransomNote.



//Example 1:

//Input: ransomNote = "a", magazine = "b"
//Output: false
//Example 2:

//Input: ransomNote = "aa", magazine = "ab"
//Output: false
//Example 3:

//Input: ransomNote = "aa", magazine = "aab"

//Output: true
    internal static partial class Solutions
    {
        public static bool RansomNote(string ransomNote, string magazine)
        {
            List<char> list = new List<char>(magazine);
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (!list.Remove(ransomNote[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}