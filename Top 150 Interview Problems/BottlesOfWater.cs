public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int totalDrinks = 0;
        int emptyBottles = 0;

        while(numBottles > 0){
            totalDrinks += numBottles;
            emptyBottles += numBottles;
            numBottles = emptyBottles / numExchange;
            emptyBottles %= numExchange;
        }

        return totalDrinks;
    }

}
