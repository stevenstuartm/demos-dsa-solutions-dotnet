using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet.Examples
{
    internal static partial class Solutions
    {
        //Given an integer numRows, return the first numRows of Pascal's triangle.
        //In Pascal's triangle, each number is the sum of the two numbers directly above it

        internal static IList<IList<int>> GeneratePascalTriangleRowsAbove(int numRows)
        {
            var res = new List<IList<int>>();

            for (int row = 0; row < numRows; row++)
            {
                var list = new List<int>();

                for (int index = 0; index <= row; index++)
                {
                    list.Add(
                        (index == 0 || index == row) ?
                            1
                            : res[row - 1][index - 1] + res[row - 1][index]
                        );
                }

                res.Add(list);
            }

            return res;
        }
    }
}