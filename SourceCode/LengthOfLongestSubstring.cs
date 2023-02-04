public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        var h = new Dictionary<char, int>();
        var max = 0;
        var l = 0;
        var r = 0;
        
        while(r != s.Length)
        {
            var added = h.TryAdd(s[r], r);
            
            if(!added)
            {
                l = Math.Max(l, h[s[r]] + 1);
                h[s[r]] = r;
            }
            
            max = Math.Max(r - l + 1, max);
            r ++;
        }
        
        return max;
    }
}
