    public static int RemoveDuplicates(int[] nums)
    {
        if(nums.Length <= 2) return nums.Length;

        int slow = 2;

        for(int fast = 0; fast < nums.Length; fast++) // fast is used to scan the array 
        {
            if (nums[slow - 2] != nums[fast]) // if the current number is different than the number slow - 2, mean the number hasn't appeared more than twice in array
            {
                nums[slow] = nums[fast]; // copy this number position pointed by slow 
                slow++; // and move slow one step forward
            } // we keep at least 2 duplicates for each number in array
        }

        return slow; // return the length represented by slow
    }
