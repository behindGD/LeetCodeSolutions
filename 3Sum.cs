public class Solution 
{
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);
        IList<IList<int>> res = new List<IList<int>>();

        for (int i = 0; i < nums.Length && nums[i] <= 0; i++)
        {
            if (i == 0 || nums[i - 1] != nums[i])
                CheckSum(i);
        }
    
        return res;

        void CheckSum(int i)
        {       
            int low = i + 1, high = nums.Length - 1;
            while (low < high)
            {
                int sum = nums[i] + nums[low] + nums[high];
                if (sum > 0)
                {
                    high--;
                }
                else if (sum < 0)
                {
                    low++;
                }
                else
                {
                    res.Add(new List<int>{nums[i], nums[low], nums[high]});
                    low++;
                    high--;
                    while (low < high && nums[low] == nums[low - 1])
                    {
                        low++;
                    }
                }
            }
        }
    }
}
