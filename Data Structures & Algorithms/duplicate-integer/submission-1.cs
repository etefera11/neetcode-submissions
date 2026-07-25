public class Solution {
    public bool hasDuplicate(int[] nums) {
        // create dictionary
        List<int> numsSeen = [];
        if (nums.Length > 1)
            // iterate through the list of nums
            for (int i = 0; i < nums.Length; i++)
            {
                // check if the number is in the dictionary
                // if it is increment it's value by 1
                // if not add the number as a key and initialize w/ a value of 1

                if (numsSeen.Contains(nums[i]))
                    return true;
                else
                    numsSeen.Add(nums[i]);
            }

        return false;
    }
}