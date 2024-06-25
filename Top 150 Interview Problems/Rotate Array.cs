class Solution
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        Rotate(nums, 3);
    }

    public static void Rotate(int[] nums, int k)
    {        
        int length = nums.Length;
        k %= length;
        Reverse(nums, 0, length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, length - 1);

        foreach(int i in nums)
        {
            Console.WriteLine(i);
        }
    }

    public static void Reverse(int[] nums, int start, int end)
    {
        while(start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }
    }
}
