public class Solution {
    public int LongestConsecutive(int[] nums) {
        // declare hashset to store nums
        var numsSet = new HashSet<int>();
        // iterate through the nums array and store nums in a hash set
        foreach(int num in nums)
            numsSet.Add(num);
        // declare int to track longest consecutive
        var longestConsecutive = new SortedSet<int>();
        

        foreach(int num in nums)
        {
            int n = 1;
            while(numsSet.Contains(num + n))
            {
                n++;
            }
            
            longestConsecutive.Add(n);
        }

        return longestConsecutive.Max;
    }
}
