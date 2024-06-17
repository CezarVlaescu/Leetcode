public class Solution {
    public bool JudgeSquareSum(int c) {
        if(c == 0)
            return true;
        int max = (int)Math.Sqrt(c);

        for(int i = 0; i <= max; i++) {
            double b = Math.Sqrt(c - i * i);
            if ((int)b == b)
                return true;
        }
        return false;
    }
}
