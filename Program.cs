using demos.dsa.solutions.dotnet.Examples;

namespace demos.dsa.solutions.dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Solutions.MajorityElement([2, 2, 2, 1, 3, 4, 5, 6]);

            Console.WriteLine(result);
            //Console.WriteLine(string.Join(",", result));
        }
    }
}