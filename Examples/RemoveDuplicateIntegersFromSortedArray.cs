namespace demos.dsa.solutions.dotnet.Leetcode
{
//Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.The relative order of the elements should be kept the same.Then return the number of unique elements in nums.
//Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
//Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially.The remaining elements of nums are not important as well as the size of nums.
//Return k.

    internal static partial class Solutions
    {
        public static int RemoveDuplicateIntegers(int[] nums)
        {
            int index = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[index] = nums[i + 1];
                    index++;
                }
                
                continue;
            }

            //If we were to write this for real we would blank out the array values after index and not even return anything.
            //Or we would return a new array ... which makes more sense.
            //but the original test wanted it this way. So the result is correct for the first values as defined by index.

            return index;
        }
    }
}