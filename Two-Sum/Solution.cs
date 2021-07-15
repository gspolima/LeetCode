using System;

namespace Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var results = new int[2];

            for (int index = 0; index < nums.Length; index++)
            {
                if(results[1] != 0)
                    break;

                for (int elementIndex = 0; elementIndex < nums.Length; elementIndex++)
                {
                    if (index != elementIndex)
                    {
                        var sum = nums[index] + nums[elementIndex];
                        if (sum == target)
                        {
                            results[0] = index;
                            results[1] = elementIndex;
                        }
                    }
                }
            }

            return results;
        }
    }
}