    public static void Main()
    {
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        Console.WriteLine(RemoveDuplicatesSwap(nums));
    }

    public static int RemoveDuplicates(int[] nums)
    {
        HashSet<int> arrayValues = new HashSet<int>();

        foreach(int i in nums)
        {
            if (!arrayValues.Contains(i)) arrayValues.Add(i);
            else continue;
        }

        return arrayValues.Count;
    }

--------------------------------------------------------------------------------
    
  public static int RemoveDuplicatesSwap(int[] nums)
    {
        int k = 0;
        int length = nums.Length - 1;

        for(int i = 0; i < length - 1; i++) 
        {
            if (nums[i] == nums[i + 1])
            {
                int temp = nums[i];
                nums[i] = nums[length];
                nums[length] = temp;
                i--;
                length--;
            }
            else k++;
        }
        return k;
    }
