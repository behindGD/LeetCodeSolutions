public class Solution 
{
    public int Jump(int[] nums) 
    {
        int[] costs = new int[nums.Length];
        Array.Fill(costs, Int32.MaxValue);
        costs[0] = 0;
        for (int i = 1; i < nums.Length; i ++)
            for (int j = 0; j < i; j ++)
                if (j + nums[j] >= i) 
                    costs[i] = Math.Min(costs[i], costs[j] + 1);
        return costs[nums.Length - 1];
    }
}
