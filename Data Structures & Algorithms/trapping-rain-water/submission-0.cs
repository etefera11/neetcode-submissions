public class Solution {
    public int Trap(int[] height) {
        var maxLeft = new int[height.Length];
        var maxRight = new int[height.Length];
        var minHeight = new int[height.Length];
        int trapped = 0;
        // iterate through array and calculate max left height
        for (int i = 0; i < height.Length; i++)
        {
            if (i == 0)
            {
                maxLeft[i] = 0;
                continue;
            }

            maxLeft[i] = Math.Max(maxLeft[i - 1], height[i - 1]);
        }

                // iterate through array and calculate max left height
        for (int i = height.Length - 1; i >= 0; i--)
        {
            if (i == height.Length - 1)
            {
                maxRight[i] = 0;
                continue;
            }

            maxRight[i] = Math.Max(maxRight[i + 1], height[i + 1]);
        }

        for (int i = 0; i < height.Length; i++)
        {
            var diff = Math.Min(maxRight[i], maxLeft[i]) - height[i];
            if (diff >= 0)
                trapped += diff;
        }

        return trapped;
    }
}
