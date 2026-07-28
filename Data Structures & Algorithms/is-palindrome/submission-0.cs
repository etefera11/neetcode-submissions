public class Solution {
    public bool IsPalindrome(string s) {
        var normalizedString = "";

        //iterate through each character
        foreach(var c in s)
        {
            // check if it's not an alphanumerical char
            if(!char.IsLetterOrDigit(c))
                continue;
            // convert the char to lowercase
            var lowerChar = char.ToLower(c);

            // build the normalized string
            normalizedString += lowerChar;
        }

        var backwardsString = "";
        for (int i = normalizedString.Length - 1; i >= 0; i--)
        {
            backwardsString += normalizedString[i];
        }

        if (backwardsString == normalizedString)
            return true;
        
        return false;
    }
}
