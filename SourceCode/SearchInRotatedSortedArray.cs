public class Solution
{
    public int search(int target, int[] nums, int a, int b)
    {
        int mid = 0;
        while (a <= b)
        {
            mid = (a + b) / 2;
            if (nums[mid] > target) b = mid - 1;
            else if (nums[mid] < target) a = mid + 1;
            else return mid;
        }
        return -1;
    }
    
    public int Search(int[] nums, int target)
    {
        int pivot = 0, a = 0, b = nums.Length - 1, mid = 0;
        while (a < b && nums[a] > nums[b])
        {
            mid = (a + b) / 2;
            if (nums[mid] < nums[b]) b = mid - 1;
            else
            {
                a = mid;
                b--;
            }
        }
        pivot = b;
        if (search(target, nums, 0, pivot) != -1) return search(target, nums, 0, pivot);
        return search(target, nums, pivot + 1, nums.Length - 1);
    }
}
