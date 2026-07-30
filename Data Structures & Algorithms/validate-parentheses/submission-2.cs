public class Solution {
    public bool IsValid(string s) {
        // create a dictionary mapping closed and open parens
        var closeToOpen = new Dictionary<char, char>{
            {')','('},
            {']','['},
            {'}','{'}
        };
        var parenStack = new Stack<char>();

        foreach (char c in s)
        {
            // check if c is a closing paren
            if (closeToOpen.ContainsKey(c))
            {
                // make sure closing paren isn't the first in the stack
                // make sure open paren is equal to top of the stack
                if (parenStack.Count > 0 && closeToOpen[c] == parenStack.Peek())
                    parenStack.Pop();
                else
                    return false;
            }
            else
                parenStack.Push(c);
        }

        return parenStack.Count == 0;
    }
}
