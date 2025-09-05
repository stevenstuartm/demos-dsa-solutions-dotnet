using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet
{
    internal static partial class Solutions
    {
        public static int FirstUniqChar(string s)
        {
            var characterDictionary = new Dictionary<char, int>();

            foreach(var character in s)
            {
                if(characterDictionary.ContainsKey(character))
                {
                    characterDictionary[character]++;
                }
                else
                {
                    characterDictionary.Add(character, 1);
                }
            }

            var uniqueCharacter = characterDictionary.FirstOrDefault(c => c.Value == 1);

            return uniqueCharacter.Value == 0 ? -1 : s.IndexOf(uniqueCharacter.Key);
        }
    }
}