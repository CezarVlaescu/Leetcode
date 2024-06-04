class Solution
{
    static void Main(string[] args)
    {
        Console.Write(LongestPalindrome("bb"));
    }

    static public int LongestPalindrome(string s)
    {
        int result = 0;

        Dictionary<char, int> map = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if (!map.ContainsKey(c)) map.Add(c, 1); 
            else map[c]++;
        }

        foreach(KeyValuePair<char, int> pair in map)
        {
            if (pair.Value % 2 == 0)
            {
                result += pair.Value;
                map.Remove(pair.Key);
            }
        }

        if (map.All(v => v.Value == 1) && map.Count() != 0) result += 1;

        return result;
    }
}
