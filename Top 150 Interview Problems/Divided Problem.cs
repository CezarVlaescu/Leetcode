public class Solution
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5, 10, 6, 7, 8, 9, };
        Console.Write(CanArrange(nums, 5));
    }
    static bool CanArrange(int[] arr, int k)
    {
        List<Tuple<int, int>> tuples = new List<Tuple<int, int>>(); // create tuples with all the pairs

        int half = (int)Math.Floor((decimal)arr.Length / 2);

        // Naive way, iterate a half of array and another half of array and if the list is arr.length / 2 then return true

        for(int i  = 0; i < half; i++) 
        {
            for(int j = half; j < arr.Length; j++)
            {
                if (VerifyPairs(arr[i], arr[j], k))
                {
                    Tuple<int, int> pair = CreateTuples(arr[i], arr[j]);
                    tuples.Add(pair);
                }
            }
        }

        foreach(Tuple<int, int> pair in tuples)
        {
            Console.WriteLine($"({pair.Item1}, {pair.Item2})");
        }

        return tuples.Count == half;
    }

    static Tuple<int, int> CreateTuples(int num1, int num2) => Tuple.Create(num1, num2); // make a tuple with the pairs

    static bool VerifyPairs(int num1, int num2, int divide) => (num1 + num2) % divide == 0; // verify the pairs
}
