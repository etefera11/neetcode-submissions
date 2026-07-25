public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // initialize a dictionary of integer array keys and a list of string values
        // iterate through each string and iterate through each character within the string
        // map the count of each character (a-z) for each string and store it as a key
        // if the key exists add the string to the to the list of strings (values)
        // return a List of the values contained in the dictionary

        Dictionary<string, List<string>> anagrams = [];

        foreach (var s in strs)
        {
            var count = new int[26];
            foreach (char c in s)
            {
                count[c - 'a'] += 1;
            }

            var strCount = string.Join(",", count);
            if (anagrams.ContainsKey(strCount))
                anagrams[strCount].Add(s);
            else
                anagrams[strCount] = new List<string>{s};
        }

        return anagrams.Values.ToList();
    }
}