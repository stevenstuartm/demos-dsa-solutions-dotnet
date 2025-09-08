using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;

namespace demos.dsa.solutions.dotnet.Examples
{
    internal static partial class Solutions
    {
        public static int MaxProfit(int[] prices)
        {
            var maxProfit = 0;

            if(prices.Length > 1)
            {
                var minPrice = int.MaxValue;

                foreach (int price in prices)
                {
                    minPrice = Math.Min(minPrice, price);
                    maxProfit = Math.Max(maxProfit, price - minPrice);
                }
            }

            return maxProfit;
        }
    }
}