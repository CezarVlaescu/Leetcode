public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        List<int> list = new List<int>();
        List<int> NotInArray2 = new List<int>();
        Array.Sort(arr1);

        for(int i = 0; i < arr2.Length; i++)
        {
            for(int j = 0; j < arr1.Length; j++)
            {
                if (NotPresentInArray2(arr1[j], arr2) && !NotInArray2.Contains(arr1[j])) NotInArray2.Add(arr1[j]);
                if (arr2[i] == arr1[j]) list.Add(arr1[j]);
            }
        }

        list.AddRange(NotInArray2);

        return list.ToArray();
    }

    public bool NotPresentInArray2(int num, int[] arr2) => !arr2.Contains(num);
}
