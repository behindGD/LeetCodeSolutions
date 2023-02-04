public class Solution 
{
    public int ThreeSumClosest(int[] nums, int target) 
    {
        if (nums.Length == 3) return nums.Sum();
        
        int diff = Int32.MaxValue;
        int len = nums.Length;
        
        Array.Sort(nums);
        
        for (int i = 0; i < len && diff != 0; i ++) 
        {
            int l = i + 1;
            int r = len - 1;
            
            while (l < r) 
            {
                int sum = nums[i] + nums[l] + nums[r];
                
                if (Math.Abs(target - sum) < Math.Abs(diff)) 
                {
                    diff = target - sum;
                }
                if (sum < target) 
                {
                    l ++;
                } 
                else 
                {
                    r --;
                }
            }
        }
        
        return target - diff;
    }
}
