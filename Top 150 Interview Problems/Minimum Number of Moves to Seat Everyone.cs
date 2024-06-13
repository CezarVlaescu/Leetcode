public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        Array.Sort(seats);
        Array.Sort(students);
        int sum = 0;

        for(int i = 0; i < students.Length; i++){
           if(seats[i] > students[i]) sum += seats[i] - students[i];
           else sum += students[i] - seats[i];
        }

        return sum;
    }
}
