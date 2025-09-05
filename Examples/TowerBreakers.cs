using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet
{
    internal static partial class Solutions
    {
        public static int TowerBreakers(int n, int m)
        {
            if(m == 1 || n%2 == 0) return 2; //player 2 wins

            return 1; //player 1 wins
        }
    }
}