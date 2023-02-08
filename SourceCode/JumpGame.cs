public class Solution 
{
    public bool CanJump(int[] nums) 
    {
        bool[] reachable = new bool[nums.Length];
        reachable[0] = true;
        for (int i = 0; i < nums.Length; i++)
            if (reachable[i])
                for (int j = i + 1; j <= i + nums[i] && j < nums.Length; j++)
                    if (!reachable[j]) reachable[j] = true;
        return reachable[nums.Length - 1];
    }
}
