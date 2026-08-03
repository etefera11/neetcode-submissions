public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        // declare stack to hold temp, index pair
        // declare result array
        Stack<(int Temp, int Index)> tempStack = new Stack<(int, int)>();
        var result = new int[temperatures.Length];

        //iterate through temperature array
        for (int i = 0; i < temperatures.Length; i++)
        {
            var temp = temperatures[i];
            // iterate through stack
            if (tempStack.Count > 0)
            {
                while (tempStack.Count > 0 && temp > tempStack.Peek().Temp)
                {
                    var lastTemp = tempStack.Pop();
                    result[lastTemp.Index] = i - lastTemp.Index;
                }
            }
            tempStack.Push((temp, i));
        }

        return result;
    }
}
