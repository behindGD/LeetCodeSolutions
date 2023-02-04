public class Solution 
{
    public int MaxArea(int[] height) 
    {
        int left = 0;
        int right = height.Length - 1;
        int res = 0;
        
        while (left < right)
        {
            int amt = (right - left) * Math.Min(height[left], height[right]);
            res = Math.Max(res, amt);
            
            if (height[left] < height[right])
            {
                left ++;
            }
            else
            {
                right --;
            }
        }
        
        return res;
    }
}
