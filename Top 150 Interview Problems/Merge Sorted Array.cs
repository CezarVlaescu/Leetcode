static void Merge(int[] array1, int[] array2)
{
        if(array1.Length == 0 || array1 == null)
        {
            foreach(int i in array2) Console.WriteLine(i);
        }

        if(array2.Length == 0 || array2 == null)
        {
            foreach (int i in array1) Console.WriteLine(i);
        }

        int[] arr1 = array1.Where(x => x > 0).ToArray(); 
        int[] arr2 = array2.Where(x => x > 0).ToArray();

        int[] result = arr1.Concat(arr2).ToArray();

        Array.Sort(result);


}

-----------------------------------------------------------------------

public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var i = --m + n--;
        while (n >= 0)
            nums1[i--] = m >= 0 && nums1[m] > nums2[n] ? nums1[m--] : nums2[n--];
}
