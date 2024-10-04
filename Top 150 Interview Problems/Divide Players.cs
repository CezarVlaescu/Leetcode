public class Solution {
    public long DividePlayers(int[] skill) {
        Array.Sort(skill); // Sort the array to easily form teams
        int n = skill.Length;
        long totalChemistry = 0;
        
        int targetSum = skill[0] + skill[n - 1]; // Set the target sum for each team
        
        // Check if every pair has the same sum
        for (int i = 0; i < n / 2; i++) {
            if (skill[i] + skill[n - 1 - i] != targetSum) {
                return -1; // If any pair doesn't match, return -1
            }
            // Calculate the chemistry and add it to the total
            totalChemistry += (long)skill[i] * skill[n - 1 - i];
        }
        
        return totalChemistry; // Return the total chemistry if all pairs are valid
    }
}

class Solution
{
    static void Main()
    {
        int[] skill = { 1, 1, 2, 3 };
        Console.WriteLine(DividePlayers(skill));
    }

    static long DividePlayers(int[] skill)
    {
        // skill is a positive intiger array with even length
        // skill[i] -> skill of i player
        // divide the players into n / 2 teams of size 2
        // the total skill of each team is equal 
        // the chem of a team is equal to the product of the skills of the players on that team

        // return the sum of the chem of all teams, or return -1 if there si no way to divide the players in teams to be at skill equal

        // ex: skill = [ 3, 2, 5, 1, 3, 4]
        // output : 22
        // divide players into the following teams (1, 5), (2, 4), (3, 3) each team has a skill of 6
        // the sum is 1*5 + 2*4 + 3*3 = 22

        Array.Sort(skill);

        if (skill.Length == 0) return -1;

        if(skill.Length == 2) return skill[0] * skill[1];

        int start = 0;
        int end = skill.Length - 1;
        int finalChemestry = 1;
        int prevSum = 0;

        while (start < end)
        {
            int currSum = skill[start] + skill[end];

            if(prevSum == 0)
            {
                prevSum = currSum;
                finalChemestry = skill[start] * skill[end];
            }
            else
            {
                if (prevSum == currSum)
                {
                    finalChemestry += skill[start] * skill[end];
                }
                else
                {
                    finalChemestry = -1;
                    break;
                }
            }

            start++;
            end--;
        }

        return finalChemestry;
    }
}
