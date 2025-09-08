namespace demos.dsa.solutions.dotnet.Examples.Leetcode
{
    //You are climbing a staircase.It takes n steps to reach the top.

    //Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?

    internal static partial class Solutions
    {
        public static int ClimbStairs(int n)
        {
            //using dynamic programming, we do not need to calculate the total ways per step as we iterate
            // to the each next step. What we can do is to start from the top step and save how many steps
            // it will take to get to the top from there. Going down the stairs, we can get the total ways 
            // adding the ways of the two steps above the current one. So we need to hardcode what the first 
            // two are and we can iterate down. We end up using fibonacci to solve this, even if not intentionally.

            int[] distinctWays = new int[n + 1];
            distinctWays[0] = 1;
            distinctWays[1] = 1;

            for(int i = 2; i <= n; i++)
            {
                distinctWays[i] = distinctWays[i - 1] + distinctWays[i - 2];
            }

            return distinctWays[n];
        }
    }
}