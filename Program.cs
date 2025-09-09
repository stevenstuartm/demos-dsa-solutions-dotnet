using demos.dsa.solutions.dotnet.Examples;

namespace demos.dsa.solutions.dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Solutions.RemoveDuplicateIntegers([1, 2, 2, 2, 3, 4, 5, 6]);

            Console.WriteLine(result);
            //Console.WriteLine(string.Join(",", result));
        }
    }
}