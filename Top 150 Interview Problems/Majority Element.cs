using System.Net.NetworkInformation;

class Solution
{
    static void Main()
    {
        int[] nums = { 2, 2, 1, 1, 1, 2, 2};

        Console.Write(MajorityElement(nums));
    }
    public static int MajorityElement(int[] nums)
    {
        Dictionary<int, int> MajorityElementsDict = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(!MajorityElementsDict.ContainsKey(num)) MajorityElementsDict.Add(num, 1);
            else MajorityElementsDict[num]++;
        }

        int[] values = MajorityElementsDict.Values.ToArray();

        int max = values.Max();

        foreach(KeyValuePair<int, int> pair in MajorityElementsDict)
        {
            if(MajorityElementsDict[pair.Key] == max)
            {
                max = pair.Key;
                break;
            }
        }

        return max;

    }
}
