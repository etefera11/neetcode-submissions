public class Solution {
    public bool IsAnagram(string s, string t) {
        // initialize dictionary
        Dictionary<char, int> charCount = [];
        // check if strings are the same Length
        if (s.Length == t.Length)
        {
            // iterate through the first string
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount.ContainsKey(s[i]))
                {
                    charCount[s[i]] += 1;
                }
                else 
                {
                    charCount.Add(s[i], 1);
                }

                if (charCount.ContainsKey(t[i]))
                {
                    charCount[t[i]] -= 1;
                }
                else
                {
                    charCount.Add(t[i], -1);
                }
            }
            // check if num value is 0, if not return false.
            foreach (var num in charCount.Values)
            {
                if (num != 0)
                    return false;                
            }
            
            return true;
        }
            return false;
    }
}

