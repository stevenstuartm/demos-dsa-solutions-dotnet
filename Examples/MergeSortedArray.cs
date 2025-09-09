namespace demos.dsa.solutions.dotnet.Examples
{
//You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
//Merge nums1 and nums2 into a single array sorted in non-decreasing order.
//The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

//Example 1:
//Input: nums1 = [1, 2, 3, 0, 0, 0], m = 3, nums2 = [2, 5, 6], n = 3
//Output: [1, 2, 2, 3, 5, 6]
//Explanation: The arrays we are merging are [1, 2, 3] and [2, 5, 6].
//The result of the merge is [1, 2, 2, 3, 5, 6] with the underlined elements coming from nums1.

//Example 2:
//Input: nums1 = [1], m = 1, nums2 = [], n = 0
//Output: [1]
//Explanation: The arrays we are merging are [1] and [].

//The result of the merge is [1].

    internal static partial class Solutions
    {

        //[1, 2, 3, 0, 0, 0], nums2 = [2, 5, 6] starts with: (aIndex = 2, bIndex = 2, assign = 5)
        //[1, 2, 3, 0, 0, 6], nums2 = [2, 5, 6] starts with: (aIndex = 2, bIndex = 1, assign = 4)
        //[1, 2, 3, 0, 5, 6], nums2 = [2, 5, 6] starts with: (aIndex = 2, bIndex = 0, assign = 3)
        //[1, 2, 3, 3, 5, 6], nums2 = [2, 5, 6] starts with: (aIndex = 1, bIndex = 0, assign = 2)
        //[1, 2, 2, 3, 5, 6], nums2 = [2, 5, 6] starts with: (aIndex = 1, bIndex = -1, assign = 1)
        //[1, 2, 2, 3, 5, 6], nums2 = [2, 5, 6] starts with: (aIndex = 0, bIndex = -1, assign = 0)
        //[1, 2, 2, 3, 5, 6], nums2 = [2, 5, 6] starts with: (aIndex = -1, bIndex = -1, assign = -1)

        public static int[] MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            var aIndex = m - 1;
            var bIndex = n - 1;

            while(aIndex >= 0 || bIndex >= 0)
            {
                var aValue = aIndex >= 0 ? nums1[aIndex] : int.MinValue;
                var bValue = bIndex >= 0 ? nums2[bIndex] : int.MinValue;
                var assignmentIndex = aIndex + bIndex + 1;

                if (aValue > bValue)
                {
                    nums1[assignmentIndex] = aValue;
                    aIndex--;
                }
                else
                {
                    nums1[assignmentIndex] = bValue;
                    bIndex--;
                }
            }

            return nums1;
        }
    }
}