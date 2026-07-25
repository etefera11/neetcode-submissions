public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // create a dictionary with nums that we've seen and their index (key = index)
        Dictionary<int, int> numsSeen = [];
        //create integer array and populate with sumIndices
        int[] targetIndices = [];
        //iterate through nums and check if the target - current num exists in the dictionary
        // if it does return the index of the current num and the value of the other number (index)

        for (int i = 0; i < nums.Length; i++)
        {
            if (numsSeen.ContainsKey(target - nums[i]))
            {
                targetIndices = [numsSeen[target - nums[i]], i];
                return targetIndices;
            }

            else
                numsSeen.Add(nums[i], i);
        }
        
        return targetIndices;
    }
}
