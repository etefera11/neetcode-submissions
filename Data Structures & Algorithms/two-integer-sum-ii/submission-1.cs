public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var numbersDict = new Dictionary<int, int>();
        var result = new int[2];

        // populate dictionary to store numbers/indexes 
        // use numbers as they key for O(1) lookup
        for (int i = 0; i < numbers.Length; i++)
        {
            numbersDict.Add(numbers[i], i);
        }

        // iterate through the array and check for the target in the dictionary
        for (int i = 0; i < numbers.Length; i++)
        {
            var diff = target - numbers[i];
            if (numbersDict.ContainsKey(diff))
            {
                if (diff > numbers[i])
                {
                    result = new int[] {i + 1, numbersDict[diff] + 1};
                    return result;                    
                }
                result = new int[] {numbersDict[diff] + 1, i + 1};
                return result;
            }     
        }
        return result;
    }
}
