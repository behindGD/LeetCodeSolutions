public class Solution 
{
    public int[] Shuffle(int[] nums, int n) 
    {
        List<int> res = new();
        for (int i = 0; i < nums.Length / 2; i++)
        {
            res.Add(nums[i]);
            res.Add(nums[i + n]);
        }
        return res.ToArray();
    }
}
