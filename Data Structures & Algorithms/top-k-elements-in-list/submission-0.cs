public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // create a dictionary that maps the counts for each number in nums
        // create a list of integers to store the frequenicies (this should be nums.Length + 1)
        var count = new Dictionary<int, int>();
        var frequency = new List<int>[nums.Length + 1];

        // iterate through the frequency list and populate an empty list
        for (int i = 0; i < frequency.Length; i++)
            frequency[i] = new List<int>();
        
        // next iterate through each number

        foreach (var num in nums)
        {
            if (count.ContainsKey(num))
            {
                count[num] += 1;
            }
            else
            {
                count[num] = 1;
            }
        }
        // iterate through each count and populate frequencies with nums
        foreach (var entry in count)
        {
            frequency[entry.Value].Add(entry.Key);
        }

        int[] result = new int[k];
        int index = 0;
        for (int i = frequency.Length - 1; i > 0 && index < k; i--)
        {
            foreach (int n in frequency[i])
            {
                result[index] = n;
                index += 1;
                if (index == k)
                {
                    return result;
                }
            }
        }

        return result;
    }
}
