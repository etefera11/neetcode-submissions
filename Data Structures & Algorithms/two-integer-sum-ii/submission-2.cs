public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // create left and right pointer
        int l = 0;
        int r = numbers.Length - 1;

        // iterate through numbers and check if l and r's sum is equal to the target
        while (l < r)
        {
            var currentSum = numbers[l] + numbers[r];
            if (currentSum > target)
                r -= 1;
            else if (currentSum < target)
                l += 1;
            else
                return new int[]{l + 1, r + 1};
        }
        return new int[2];
    }
}
