using System.Text;

class Solution
{
    static void Main()
    {
        Console.WriteLine(AppendCharacters("coaching", "coding"));
    }

    static int AppendCharacters(string s, string t)
    {
        if(string.IsNullOrEmpty(s)) return t.Length;

        if (s.Length == 1 && t.All(c => c != s[0])) return t.Length;

        int sIndex = 0, tIndex = 0;

        int sLength = s.Length, tLength = t.Length;

        while (sIndex < sLength && tIndex < tLength)
        {
            if (s[sIndex] == t[tIndex]) tIndex++;
            sIndex++;
        }

        return tLength - tIndex;
    }
}
