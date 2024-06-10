public class Solution {
    public int HeightChecker(int[] heights) {
        int[] expected = (int[])heights.Clone();
        Array.Sort(expected);
        int missmatches = 0;

        for(int i = 0; i < heights.Length; i++) 
        {
            if (expected[i] != heights[i]) missmatches++;
        }

        return missmatches;
    }
}
