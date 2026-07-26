public class Solution {

    public string Encode(IList<string> strs) {
        // iterate through each string, encode, and append to the result string

        var result = "";
        foreach (var s in strs)
        {
            result += s.Length + "#" + s;
        }

        return result;
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int i = 0;

        // iterate through each character of the string
        while (i < s.Length)
        {
            int j = i;

            //read numbers at the beginning of the string
            while (s[j] != '#')
            {
                j++;
            }
            // parse out the number
            int length = int.Parse(s.Substring(i, j - i));

            //update pointer to skip over #
            i = j + 1;
            j = i + length;

            //add decoded substring to the result list
            result.Add(s.Substring(i, length));
            i = j;
        }
        return result;
   }
}
