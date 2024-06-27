public class Solution {
    public int FindCenter(int[][] edges) {
        int common = 0;

        for(int i = 0; i < edges.Length; i++){
            for(int j = 0; j < 2; j++){
                common = edges[i][j];
                if(edges[i+1].Contains(common)) return common;
                else common = 0;
            }
        }

        return 0;
    }
}
