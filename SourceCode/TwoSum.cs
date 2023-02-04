public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        List<int> list = new();
        
        for (int l = 0; l < nums.Length; l ++)
        {
            list = nums.ToList();
            list.RemoveAt(l);
            
            if (list.Contains(target - nums[l]))
            {
                int r = list.IndexOf(target - nums[l]);
                
                if (r >= l) 
                {
                    return new int[]{l, r + 1};
                }
                else
                {
                    return new int[]{r, l};
                }
            }
        }
        
        return null;
    }
}
