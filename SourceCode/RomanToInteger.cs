public class Solution 
{
    public int RomanToInt(string s) 
    {
        int res = 0;
        Dictionary<char, int> dic = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        for (int i = 0; i < s.Length; i ++)
        {
            res += dic[s[i]];
            if (i > 0 && dic[s[i]] > dic[s[i - 1]])
            {
                res -= dic[s[i - 1]] * 2;
            }
        }
        
        return res;
    }
}
