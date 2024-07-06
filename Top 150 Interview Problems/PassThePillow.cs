public class Solution {
    public int PassThePillow(int n, int time) {
        bool isRight = true;
        int first = 1;

        for(int i = 0; i < time; i++)
        {
            if (first == n) isRight = false;
            else if (first == 1) isRight = true;

            if (isRight) first++;
            else first--;
        }

        return first;
    }
}
