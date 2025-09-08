namespace demos.dsa.solutions.dotnet.Examples
{
// Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.


//Example 1:

//Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
//Output: [5, 6, 7, 1, 2, 3, 4]
//Explanation:
//rotate 1 steps to the right: [7, 1, 2, 3, 4, 5, 6]
//rotate 2 steps to the right: [6, 7, 1, 2, 3, 4, 5]
//rotate 3 steps to the right: [5, 6, 7, 1, 2, 3, 4]
//Example 2:

//Input: nums = [-1,-100,3,99], k = 2
//Output: [3, 99, -1, -100]
//Explanation: 
//rotate 1 steps to the right: [99, -1, -100, 3]
//rotate 2 steps to the right: [3, 99, -1, -100]

    internal static partial class Solutions
    {
        public static void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;

            int[] res = new int[n];

            for (int i = 0; i < n; i++)
            {
                res[(i + k) % n] = nums[i];
            }

            for (int i = 0; i < n; i++)
            {
                nums[i] = res[i];
            }


            //k = k % nums.Length;

            //Array.Reverse(nums);
            //Array.Reverse(nums, 0, k);
            //Array.Reverse(nums, k, nums.Length - k);
        }
    }
}