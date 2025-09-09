namespace demos.dsa.solutions.dotnet.Examples
{
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.

    internal static partial class Solutions
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int arrayLength = nums.Length;
            Dictionary < int, int > resultDictionary = new();

            if (nums == null || arrayLength < 2)
            {
                return Array.Empty < int > ();
            }

            for (int i = 0; i < arrayLength; i++)
            {
                int firstNumber = nums[i];
                int secondNumber = target - firstNumber;
               
                if (resultDictionary.TryGetValue(secondNumber, out int index)) {
                    return new [] {
                        index,
                        i
                    };
                }

                resultDictionary[firstNumber] = i;
            }
           
            return Array.Empty < int > ();
        }
    }
}