public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int start = prices[0];
        int len = prices.Length;
        for(int i = 1;i<len; i++){
            if(start < prices[i]){
                max += prices[i] - start;
            }
            start = prices[i];
        }
        return max;
    }
}
