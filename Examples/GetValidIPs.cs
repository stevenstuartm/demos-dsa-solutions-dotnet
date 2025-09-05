namespace demos.dsa.solutions.dotnet
{
    internal static partial class Solutions
    {
        public static IList<string> GetValidIPs(string s)
        {
            return GetValidIps(s, 0, 0, new List<string>());
        }

        private static List<string> GetValidIps(string s, int i, int segcount, List<string> result)
        {
            var ips = new List<string>();
            
            if (i >= s.Length)
            {
                if (segcount == 4)
                {
                    ips.Add(string.Join(".", result));
                }

                return ips;
            }

            if (segcount > 4) return ips;

            for (int len = 1; len <= 3; len++)            
            {                
                if (!IsValid(s, i, len)) continue;         

                result.Add(s.Substring(i, len));                
                ips.AddRange(GetValidIps(s, i + len, segcount + 1, result));                
                result.RemoveAt(result.Count - 1);            
            }

            return ips;      
        }        
        private static bool IsValid(string s, int i, int len)        
        {            
            if (i + len > s.Length) return false;
            if (len == 3 && int.Parse(s.Substring(i, len)) > 255) return false;
            if (len > 1 && s[i] == '0') return false;

            return true;
        }
    }
}