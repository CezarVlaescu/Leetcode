class Solution
{
    static void Main()
    {
        int[] nums = { 1, 1, 2, 1, 1 };
        Console.WriteLine(CountSubArraysNice(nums, 3));
    }

    static int CountSubArraysNice(int[] nums, int k)
    {
        int count = 0;
        int oddCount = 0;
        int start = 0;

        for (int end = 0; end < nums.Length; end++)
        {
            if (nums[end] % 2 != 0) oddCount++;

            while (oddCount > k)
            {
                if (nums[start] % 2 != 0) oddCount--;
                start++;
            }

            if (oddCount == k)
            {
                count++;
                int tempStart = start;
                while (tempStart < end && nums[tempStart] % 2 == 0)
                {
                    count++;
                    tempStart++;
                }
            }
        }

        return count;
    }
}
