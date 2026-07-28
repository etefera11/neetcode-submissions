public class Solution {
    public int LongestConsecutive(int[] nums) {
        // declare hashset to store nums
        var numsSet = new HashSet<int>(nums);

        // declare int to track longest consecutive
        var longestConsecutive = new SortedSet<int>();
        

        foreach(int num in nums)
        {
            if (!numsSet.Contains(num - 1))
            {
                int n = 1;
                while(numsSet.Contains(num + n))
                {
                    n++;
                }
                longestConsecutive.Add(n);
            }

        }

        return longestConsecutive.Max;
    }
}
