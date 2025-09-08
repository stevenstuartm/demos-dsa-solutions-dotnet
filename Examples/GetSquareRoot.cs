namespace demos.dsa.solutions.dotnet.Examples.Leetcode
{
    //Given a non-negative integer x, return the square root of x rounded down to the nearest integer.The returned integer should be non-negative as well.
    //You must not use any built-in exponent function or operator.

    internal static partial class Solutions
    {
        //using binary search
        public static int GetSquareRoot1(int x)
        {
            var res = 0;
            var low = 1;
            var high = x;

            while (low <= high)
            {
                var mid = (high - low) / 2 + low;

                if (mid == x / mid)
                {
                    res = mid;
                    break;
                }
                else if( mid < x / mid)
                {
                    res = mid;
                    low = mid + 1;
                }
                
                high = mid - 1;
            }

            return res;
        }

        //using Newtons's method
        public static int GetSquareRoot2(int x)
        {
            if (x <= 1)             
            {
                return x;        
            }
            var guess = x / 2.0;             
            var newGuess = guess / 2.0 + x / (2.0 * guess);

            while (Math.Abs(newGuess - guess) > 0.001)
            {
                guess = newGuess;
                newGuess = guess / 2.0 + x / (2.0 * guess);
            }

            return (int)newGuess;
        }
    }
}