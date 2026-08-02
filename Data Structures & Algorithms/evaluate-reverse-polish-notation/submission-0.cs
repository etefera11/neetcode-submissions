public class Solution {
    public int EvalRPN(string[] tokens) {
        // hashset to hold operators for lookup
        var operandSet = new HashSet<string>{"+", "-", "*", "/"};
        // stack to track numbers from the string
        var evalStack = new Stack<int>();
        int result = 0;

        // iterate through the list of nums in the string
        foreach (var c in tokens)
        {
            var total = 0;
            // check if its an operator and calculate in reverse polish notation if so
            if (operandSet.Contains(c))
            {
                var a = evalStack.Pop();
                var b = evalStack.Pop();
                switch (c)
                {
                    case "+":
                        total += b + a;
                        break;
                    case "-":
                        total += b - a;
                        break;
                    case "*":
                        total += b * a;
                        break;
                    case "/":
                        total += b / a;
                        break;   
                }
                evalStack.Push(total);
            }
            else
            {
                evalStack.Push(Convert.ToInt32(c));
            }
        }

        result = evalStack.Pop();

        return result;
    }
}
