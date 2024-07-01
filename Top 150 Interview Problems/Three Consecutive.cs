public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {        
        
        if(arr.Length < 3) return false;
        if(arr.All(v => !(v % 2 == 0))) return true;
                
        List<int> odds = new List<int>();

        for(int i = 0; i < arr.Length; i++){
            if(arr[i] % 2 == 0) odds.Clear();
            else odds.Add(arr[i]);

            if(odds.Count == 3) {
                return true;
                break;
            }
        }

        return false;
    }
}
