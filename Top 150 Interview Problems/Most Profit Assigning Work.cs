public class Solution {
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker) {
        int n = difficulty.Length;
        
        // Step 1: Pair jobs and sort by difficulty
        List<int[]> jobs = new List<int[]>();
        for (int i = 0; i < n; i++) {
            jobs.Add(new int[] { difficulty[i], profit[i] });
        }
        jobs.Sort((a, b) => a[0].CompareTo(b[0]));
        
        // Step 2: Create max profit map
        Dictionary<int, int> maxProfitMap = new Dictionary<int, int>();
        int maxProfit = 0;
        foreach (var job in jobs) {
            maxProfit = Math.Max(maxProfit, job[1]);
            if (!maxProfitMap.ContainsKey(job[0])) {
                maxProfitMap[job[0]] = maxProfit;
            } else {
                maxProfitMap[job[0]] = Math.Max(maxProfitMap[job[0]], maxProfit);
            }
        }
        
        // Step 3: Sort workers by ability
        Array.Sort(worker);
        
        // Step 4: Calculate total profit
        int totalProfit = 0;
        int currentMaxProfit = 0;
        int jobIndex = 0;
        
        foreach (var ability in worker) {
            // Update currentMaxProfit for the worker's ability
            while (jobIndex < jobs.Count && jobs[jobIndex][0] <= ability) {
                currentMaxProfit = Math.Max(currentMaxProfit, jobs[jobIndex][1]);
                jobIndex++;
            }
            totalProfit += currentMaxProfit;
        }
        
        return totalProfit;
    }
}
