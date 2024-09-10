class Solution
{
    static void Main()
    {
        int[] arr = { 7 };
        int[] res = InsertGreatestCommonDivisors(arr);

        foreach(int i in res)
        {
            Console.WriteLine(i);
        }
    }

    static int[] InsertGreatestCommonDivisors(int[] list)
    {
        List<int> ints = new List<int>();
        List<int> result = new List<int>();
        int first = 0;
        int second = 1;

        if (list.Length == 0) return Array.Empty<int>();

        if (list.Length == 1) return list;

        while(second < list.Length)
        {
            int prev = list[first];
            result.Add(prev);
            int next = list[second];

            if(prev < next)
            {
                if(next % prev == 0) result.Add(prev);
                else
                {
                    int divisor = prev;

                    while (divisor > 1)
                    {
                        if (next % divisor == 0 && prev % divisor == 0) break;
                        divisor--;
                    }

                    result.Add(divisor);
                }
            }
            else
            {
                if(prev % next == 0) result.Add(next);
                else
                {
                    int divisor = next;

                    while (divisor > 1)
                    {
                        if (next % divisor == 0 && prev % divisor == 0) break;
                        divisor--;
                    }

                    result.Add(divisor);
                }
            }

            result.Add(next);

            if (first != 0) result.RemoveAt(0);

            foreach (int i in result) 
            {
                ints.Add(i);
            }


            first++;
            second++;

            result.Clear();
        }

        return ints.ToArray();
    }
}
