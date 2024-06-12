public class Solution {
    public void SortColors(int[] nums) {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                i = -1;
            }
        }

        foreach (int i in nums) Console.WriteLine(i);
    }
}
