public class Solution {
    public int MinDifference(int[] nums) {
        int n = nums.Length;
        if (n <= 4) return 0; // If there are 4 or fewer elements, we can always make the difference 0
        
        Array.Sort(nums);
        
        // Calculate all potential differences
        int minDifference = int.MaxValue;
        
        // Scenario 1: Remove 3 largest elements
        minDifference = Math.Min(minDifference, nums[n-4] - nums[0]);
        
        // Scenario 2: Remove 2 largest elements and the smallest element
        minDifference = Math.Min(minDifference, nums[n-3] - nums[1]);
        
        // Scenario 3: Remove 1 largest element and 2 smallest elements
        minDifference = Math.Min(minDifference, nums[n-2] - nums[2]);
        
        // Scenario 4: Remove 3 smallest elements
        minDifference = Math.Min(minDifference, nums[n-1] - nums[3]);
        
        return minDifference;
    }
}
