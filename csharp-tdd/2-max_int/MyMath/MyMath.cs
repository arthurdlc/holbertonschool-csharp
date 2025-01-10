using System;
using System.Collections.Generic;

namespace MyMath
{
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            // Check if the list is empty
            if (nums == null || nums.Count == 0)
            {
                return 0; // Return 0 if the list is empty
            }

            // Initialize max with the first element of the list
            int max = nums[0];

            // Iterate through the list to find the maximum value
            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num; // Update max if a larger number is found
                }
            }

            return max; // Return the maximum value found
        }
    }
}