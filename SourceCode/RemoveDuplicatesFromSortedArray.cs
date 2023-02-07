public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int res = 0;
        
        for (int i = 0; i < nums.Length; i++) 
        {
            if (i < nums.Length - 1 && nums[i] == nums[i + 1]) continue;
            nums[res] = nums[i];
            res++;
        }
        
        return res;
    }
}
