public class Solution {
    public int MinOperations(string[] logs) {
        int result = 0;

        for(int i = 0; i < logs.Length; i++) 
        {
            switch (logs[i])
            {
                case "../": if(result > 0) result--; break;
                case "./": break;
                default: result++; break;
            }
        }

        return result;
    }
}
