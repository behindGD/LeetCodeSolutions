public class Solution 
{
    public int TotalFruit(int[] fruits) 
    {
        List<int> pickedTypes = new(){fruits[0]};
        int l = 0, r = 1, max = 1;
        while (r < fruits.Length)
        {
            if (!pickedTypes.Contains(fruits[r])) pickedTypes.Add(fruits[r]);
            if (pickedTypes.Count > 2)
            {
                pickedTypes.RemoveAt(0);
                l = r - 1;
                while (l >= 0 && (fruits[l] == pickedTypes[1] || fruits[l] == pickedTypes[0])) l--;
                l++;
            }
            max = Math.Max(max, r - l + 1);
            r++;
        }
        return max;
    }
}
