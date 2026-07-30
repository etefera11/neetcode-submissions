public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // declare result list and sort the array
        var result = new List<List<int>>();
        Array.Sort(nums);
        
        // iterate through the array of nums
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i -1])
                continue;
            // calculate left and right pointers
            int l = i + 1;
            int r = nums.Length - 1;

            // iterate through the left and right pointers and filter duplicates
            while (l < r)
            {
                // calculate current sum
                var currentSum = nums[i] + nums[l] + nums[r];
                if (currentSum > 0)
                    r -= 1;
                else if (currentSum < 0)
                    l += 1;
                else // current sum = 0
                {
                    result.Add(new List<int>{nums[i], nums[l], nums[r]});
                    // shift left pointer
                    l += 1;
                    // increment left pointer if equal to the previous num
                    while (nums[l] == nums[l - 1] && l < r)
                        l += 1;
                }
            }
        }

        return result;
    }
}
