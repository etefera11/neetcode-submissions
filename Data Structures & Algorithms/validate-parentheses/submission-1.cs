public class Solution {
    public bool IsValid(string s) {
        // create a dictionary to hold open and close parentheses
        // create a stack to hold string
        var parenDict = new Dictionary<char, char>{{'(', ')'}, {'[', ']'}, {'{', '}'}};
        var parenStack = new Stack<char>();

        foreach (char c in s)
        {
            // check if c is an opening bracket (key) in dict
            if (parenDict.ContainsKey(c))
                parenStack.Push(c);
            else if (parenStack.Count > 0)
            {
                var lastChar = parenStack.Pop();
                if (parenDict[lastChar] != c)
                    return false;
            }
            else
                return false;

        }

        return parenStack.Count == 0;
    }
}
