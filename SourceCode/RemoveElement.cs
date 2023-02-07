public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        int l = 0, r = nums.Length;
        
        while (l < r)
        {
            if (nums[l] == val)
            {
                nums[l] = nums[r - 1];
                r --;
            }
            else l ++;
        }
        return r;
    }
}
