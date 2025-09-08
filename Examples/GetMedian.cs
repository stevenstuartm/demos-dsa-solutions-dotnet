using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet.Examples
{
    internal static partial class Solutions
    {
        public static double GetMedian(double[] arrSource)
        { 	
            if (arrSource == null || arrSource.Length == 0)
                throw new ArgumentException("Array is empty.");
        
            double[] arrSorted = (double[])arrSource.Clone();
            Array.Sort(arrSorted);
        
            int size = arrSorted.Length;
            int mid = size / 2;
        
            if (size % 2 != 0)
                return arrSorted[mid];
        
            dynamic value1 = arrSorted[mid];
            dynamic value2 = arrSorted[mid - 1];
            
            return (value1 + value2) / 2;
        }
    }
}