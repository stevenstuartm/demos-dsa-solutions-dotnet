using System.Text;

namespace demos.dsa.solutions.dotnet.Examples
{
    internal static partial class Solutions
    {
        public static string CaesarCipher(string s, int k)
        {
            const int ZasciiValue = (int)'Z';
            const int zAsciiValue = (int)'z';
            const int numberOfLetters = 26;
            
            StringBuilder result = new StringBuilder();
    
            for (int i = 0; i < s.Length; i++)
            {
                var charValue = s[i];
                
                if(!char.IsLetter(charValue))
                {
                    result.Append(charValue);   
                }
                else
                {
                    var charAsciiValue = (int)charValue;
                    int newCharAsciiValue = charAsciiValue + (k % numberOfLetters);
                    
                    if((Char.IsUpper(charValue) && newCharAsciiValue > ZasciiValue)
                        || (Char.IsLower(charValue) && newCharAsciiValue > zAsciiValue))
                    {
                        newCharAsciiValue = newCharAsciiValue - numberOfLetters;
                    }

                    result.Append((char)newCharAsciiValue);
                }
            }
            
            return result.ToString();
        }
    }
}