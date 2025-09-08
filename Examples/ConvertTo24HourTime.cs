using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet.Examples
{
    internal static partial class Solutions
    {
        public static string ConvertTo24HourTime(string s)
        {
            var dateTime = DateTime.Parse(s);
            
            return dateTime.ToString("HH:mm:ss");
        }
    }
}