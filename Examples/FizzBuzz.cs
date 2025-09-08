namespace demos.dsa.solutions.dotnet.Examples
{
    internal static partial class Solutions
    {
//        Given an integer n, return a string array answer(1-indexed) where:

//answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
//answer[i] == "Fizz" if i is divisible by 3.
//answer[i] == "Buzz" if i is divisible by 5.
//answer[i] == i(as a string) if none of the above conditions are true.

        public static IList<string> FizzBuzz(int n)
        {
            var answers = new string[n];

            for (int i = 1; i <= n; i++)
            {
                var divisibleBy3 = i % 3 == 0;
                var divisibleBy5 = i % 5 == 0;


                if (divisibleBy3 && divisibleBy5)
                    answers[i - 1] = "FizzBuzz";
                else if (divisibleBy3)
                    answers[i - 1] = "Fizz";
                else if (divisibleBy5)
                    answers[i - 1] = "Buzz";
                else
                    answers[i - 1] = i.ToString();
            }

            return answers;
        }
    }
}