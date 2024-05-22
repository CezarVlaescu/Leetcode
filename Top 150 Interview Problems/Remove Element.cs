static int RemoveElement(int[] nums, int val)
{
        List<int> list = new List<int>();

        foreach(int i in nums)
        {
            if (i == val) continue;
            else list.Add(i);
        }

        return list.Count;
}

----------------------------------------------

    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        int j = nums.Length - 1;
        for (int i = 0; i <= j; i++) {
            if (nums[i] == val) {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                j--;
                i--;
            } else {
                k++;
            }
        }
        return k;
    }
