public class Solution {
    public int SpecialArray(int[] nums) {
        if(nums.All(num => num == 0)) return -1;
        int x = 0; 

        while(x <= nums.Length){
            int count = nums.Count(i => i >= x);
            if(count == x) return count;
            else x++;
        }
        return -1;
    }
}
