public class Solution {
    public int MaxArea(int[] heights) {
        int result = 0;
        int l = 0;
        int r = heights.Length - 1;

        // iterate through heights
        while (l < r)
        {
            // compute the area width * height
            int width = r - l;
            int area = width * Math.Min(heights[l], heights[r]);
            if (heights[r] - heights[l] >= 0)
                l++;
            else
                r--;
            result = Math.Max(area, result);
        }

        return result;
    }
}
